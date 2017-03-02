using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Web;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows;
using System.ComponentModel;

namespace PhapY.App_Code
{
    public class Common
    {
        public Common()
        {
        }

        #region Common Method

        public static string ConnectionString
        {
            get
            {
                string ServerName = PhapY.Properties.Settings.Default.ServerName;
                string DatabaseName = PhapY.Properties.Settings.Default.DatabaseName;
                string UserName = PhapY.Properties.Settings.Default.UserName;
                string Password = PhapY.Properties.Settings.Default.Password;

                string strConnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + UserName + ";Password=" + Password;
                return strConnectionString;
            }
        }

        #endregion
    }
}
