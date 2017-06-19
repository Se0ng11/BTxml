namespace BT_XML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LvView = new System.Windows.Forms.ListView();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.btnImportFolder = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lvSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModBit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverCntrl1 = new BT_XML.ServerCntrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvView
            // 
            this.LvView.AllowDrop = true;
            this.LvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Status});
            this.LvView.HideSelection = false;
            this.LvView.Location = new System.Drawing.Point(164, 164);
            this.LvView.Name = "LvView";
            this.LvView.Size = new System.Drawing.Size(621, 260);
            this.LvView.TabIndex = 0;
            this.LvView.TabStop = false;
            this.LvView.UseCompatibleStateImageBehavior = false;
            this.LvView.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "Files Name";
            this.FileName.Width = 550;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // btnImportFolder
            // 
            this.btnImportFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnImportFolder.Location = new System.Drawing.Point(5, 164);
            this.btnImportFolder.Name = "btnImportFolder";
            this.btnImportFolder.Size = new System.Drawing.Size(153, 31);
            this.btnImportFolder.TabIndex = 1;
            this.btnImportFolder.Text = "Import Folder";
            this.btnImportFolder.UseVisualStyleBackColor = false;
            this.btnImportFolder.Click += new System.EventHandler(this.btnImportFolder_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(629, 434);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(710, 434);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lvSP
            // 
            this.lvSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSP.FullRowSelect = true;
            this.lvSP.HideSelection = false;
            this.lvSP.Location = new System.Drawing.Point(5, 12);
            this.lvSP.MultiSelect = false;
            this.lvSP.Name = "lvSP";
            this.lvSP.Size = new System.Drawing.Size(780, 146);
            this.lvSP.TabIndex = 7;
            this.lvSP.TabStop = false;
            this.lvSP.UseCompatibleStateImageBehavior = false;
            this.lvSP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Store Procedure";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Parameter";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "format";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 180;
            // 
            // btnImportFile
            // 
            this.btnImportFile.BackColor = System.Drawing.Color.Transparent;
            this.btnImportFile.Location = new System.Drawing.Point(5, 201);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(153, 31);
            this.btnImportFile.TabIndex = 2;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = false;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Monotype Corsiva", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(3, 442);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(65, 11);
            this.lblHelp.TabIndex = 9;
            this.lblHelp.TabStop = true;
            this.lblHelp.Text = "Created By Se^0^ng";
            this.lblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHelp_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModBit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer mode";
            // 
            // txtModBit
            // 
            this.txtModBit.Location = new System.Drawing.Point(9, 32);
            this.txtModBit.Name = "txtModBit";
            this.txtModBit.Size = new System.Drawing.Size(138, 20);
            this.txtModBit.TabIndex = 1;
            this.txtModBit.Text = "99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modbit";
            // 
            // serverCntrl1
            // 
            this.serverCntrl1.Location = new System.Drawing.Point(5, 238);
            this.serverCntrl1.Name = "serverCntrl1";
            this.serverCntrl1.ServerTag = "";
            this.serverCntrl1.ServerName = "";
            this.serverCntrl1.Size = new System.Drawing.Size(155, 186);
            this.serverCntrl1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 460);
            this.Controls.Add(this.serverCntrl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.lvSP);
            this.Controls.Add(this.LvView);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnImportFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(813, 499);
            this.MinimumSize = new System.Drawing.Size(813, 499);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Tool V1.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvView;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button btnImportFolder;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListView lvSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.LinkLabel lblHelp;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModBit;
        private System.Windows.Forms.Label label1;
        private ServerCntrl serverCntrl1;
    }
}

