using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVC5App.Models
{
    public class Helpers
    {
        public static string GetRDSConnection()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["RDS_DB_NAME"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = "matildadbinstance";// "sahib_web_app_db_instance";//appConfig["RDS_USERNAME"];
            string password = "admin";// appConfig["RDS_PASSWORD"];
            string hostname = "aa176a1auc5aw0j.cwuhshyngbgi.us-east-1.rds.amazonaws.com";//appConfig["RDS_HOSTNAME"];
            string port = "1433";// appConfig["RDS_PORT"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}