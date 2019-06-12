using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Exceptions
{
    static class ExceptionLogger
    {
        public static void LogAnExcaption(Exception e)
        {
            StreamWriter stream = File.AppendText("Log.txt");
            stream.Write(DateTime.Now + " - " + e.Message + "\n");
            stream.Flush();
            stream.Close();
        }
    }
}
