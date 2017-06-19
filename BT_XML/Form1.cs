using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace BT_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LvView.AllowDrop = true;
            LvView.DragDrop += new DragEventHandler(LvView_DragDrop);
            LvView.DragEnter += new DragEventHandler(LvView_DragEnter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetFileSetting();
        }

        private void btnImportFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;    
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                var files = Directory.GetFiles(fbd.SelectedPath, "*.xml",SearchOption.AllDirectories);
                var lv = LvView.Items.Cast<ListViewItem>();

                foreach (var s in files)
                {
                    if (LvView.Items.Count > 0)
                    {
                        if (!lv.Any(x=> x.Text == s))
                        {
                            LvView.Items.Add(s);
                        }
                    }
                    else
                    {
                        LvView.Items.Add(s);
                    }
                }
            }
        }


        private void btnImportFile_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();

            fd.Filter = "Text files|*.xml;*.txt";

            DialogResult dR = fd.ShowDialog();

            if (dR == DialogResult.OK)
            {
                var lv = LvView.Items.Cast<ListViewItem>();

                if (!lv.Any(x => x.Text == fd.FileName)){
                    LvView.Items.Add(fd.FileName);
                }
                
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LvView.Items.Clear();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var lv = LvView.Items.Cast<ListViewItem>();
            var rnd = new Random();
            var obj = new AppConfigBAL();
            if (lv.Count() > 0)
            {
                //process xml
                if (lvSP.SelectedItems.Count != 0)
                {
                    DialogResult dr = MessageBox.Show("Click OK to start process xml", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    
                    if (dr == DialogResult.OK)
                    {
                        ToggleButton(false);
                        try
                        {
                            var sp = lvSP.SelectedItems;
                           
                            foreach (var s in lv)
                            {
                                using (var sr = new StreamReader(s.Text))
                                {
                                    using (var con = new SqlConnection(serverCntrl1.ServerTag))
                                    {
                                        using (var cmd = new SqlCommand(sp[0].Text, con))
                                        {
                                            cmd.CommandType = CommandType.StoredProcedure;

                                            var param = sp[0].SubItems[1].Text.Split(',');
                                            var paramType = sp[0].SubItems[2].Text.Split(',');

                                            for (int i = 0; i <= param.Count() - 1; i++)
                                            {
                                                if (paramType[i] == "xml")
                                                {
                                                    cmd.Parameters.AddWithValue(param[i], sr.ReadToEnd());
                                                }
                                                else if (paramType[i] == "date")
                                                {
                                                    cmd.Parameters.AddWithValue(param[i], DateTime.Now);
                                                }
                                                else if (paramType[i] == "string")
                                                {
                                                    cmd.Parameters.AddWithValue(param[i], obj.ReadDefaultServer());
                                                }
                                                else if (paramType[i] == "int")
                                                {
                                                    cmd.Parameters.AddWithValue(param[i], rnd.Next(0,100));
                                                }

                                            }

                                            con.Open();
                                            con.ChangeDatabase(ModelsSelection());
                                            var result = cmd.ExecuteNonQuery();
                                            s.UseItemStyleForSubItems = false;
                                            if (result > 0)
                                            {
                                                s.SubItems.Add("Success");
                                                s.SubItems[1].ForeColor = System.Drawing.Color.Green;
                                            }
                                            else
                                            {
                                                s.SubItems.Add("Failed");
                                                s.SubItems[1].ForeColor = System.Drawing.Color.Red;
                                            }
                                            LvView.Update();
                                        }
                                    }
                                }
                            }

                            MessageBox.Show(serverCntrl1.ServerName + " deployment complete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ToggleButton(true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ToggleButton(true);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please select a store procedure to continue!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No xml files found in the list, please add xml files before proceed!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleButton(Boolean flag)
        {
            btnProcess.Enabled = flag;
            btnImportFolder.Enabled = flag;
            btnClearAll.Enabled = flag;
            btnImportFile.Enabled = flag;

        }

        private void GetFileSetting()
        {
            var currentSetting = Directory.GetCurrentDirectory() + "\\setting.txt";

            if (File.Exists(currentSetting))
            {
                using (var sr = new StreamReader(currentSetting))
                {
                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        var str = line.Split(';');
                        var item = lvSP.Items.Add(str[0]);
                        if (item.Text != "")
                        {
                            item.SubItems.Add(str[1]);
                            item.SubItems.Add(str[2]);
                            item.SubItems.Add(str[3]);
                        }
                    }
                }
            }
            else
            {
                File.Create(currentSetting);
            }
        }

        private void lblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Parameter type as below \n================\n xml = file that contain xml \n date = date time now \n string = defined string that get from config \n int = random number between 0-100", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ModelsSelection()
        {
            return "BB_interface";
        }

        private void LvView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LvView_DragDrop(object sender, DragEventArgs e)
        {
            string[] locName = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (var loc in locName)
            {
                if (loc.Contains(".xml"))
                {
                    //file
                    var lv = LvView.Items.Cast<ListViewItem>();

                    if (!lv.Any(x => x.Text == loc))
                    {
                        LvView.Items.Add(loc);
                    }

                }
                else if (!loc.Contains("."))
                {
                    //folder
                    var files = Directory.GetFiles(loc, "*.xml", SearchOption.AllDirectories);
                    var lv = LvView.Items.Cast<ListViewItem>();

                    foreach (var s in files)
                    {
                        if (LvView.Items.Count > 0)
                        {
                            if (!lv.Any(x => x.Text == s))
                            {
                                LvView.Items.Add(s);
                            }
                        }
                        else
                        {
                            LvView.Items.Add(s);
                        }
                    }
                }
            }
        }
    }
}


    