using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhapY.App_Code
{
    class CreateLogFiles
    {

        private string sLogFormat;
        private string sErrorTime;

        public CreateLogFiles()
        {
            //sLogFormat used to create log files format :
            // dd/mm/yyyy hh:mm:ss AM/PM ==> Log Message
            sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";

            //this variable used to create log filename format "
            //for example filename : ErrorLogYYYYMMDD
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            sErrorTime = sDay+ sMonth + sYear;
        }
        public void ErrorLog(string sPathName, string sErrMsg)
        {
            if (!Directory.Exists(sPathName + "\\LogFile"))
                Directory.CreateDirectory(sPathName + "\\LogFile");
            StreamWriter sw = new StreamWriter(sPathName +"\\LogFile" + "\\" + sErrorTime + ".txt", true);
            sw.WriteLine(sLogFormat + sErrMsg);
            sw.Flush();
            sw.Close();
        }
    }
}
