using System.Collections.Generic;
using System.Configuration;

namespace BT_XML
{
    class AppConfigBAL
    {

        public List<AppConfigDAL> ListOfConnection()
        {
            var result = new List<AppConfigDAL>();

            foreach (ConnectionStringSettings v in ConfigurationManager.ConnectionStrings)
            {
                if (v.Name != "LocalSqlServer") {
                    var t = new AppConfigDAL();
                    t.Name = v.Name;
                    t.ConnectionString = v.ConnectionString;

                    result.Add(t);
                }

            }

            return result;
        }

        public string ReadTitle()
        {
            return ConfigurationManager.AppSettings["Title"];
        }

        public string ReadDefaultServer()
        {
            return ConfigurationManager.AppSettings["DefaultServer"];
        }

       
    }
}
