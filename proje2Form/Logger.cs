using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form
{
    class Logger
    {
        public static void ProgramStarted()
        {
            StreamWriter stream = File.AppendText("Log.txt");
            stream.Write("Pogram Started At " + DateTime.Now + "\n");
            stream.Flush();
            stream.Close();
        }

        public static void ProgramStopped()
        {
            StreamWriter stream = File.AppendText("Log.txt");
            stream.Write("Pogram Stopped At " + DateTime.Now + "\n");
            stream.Flush();
            stream.Close();
        }

        public static void DatabaseLoaded(string file)
        {
            StreamWriter stream = File.AppendText("Log.txt");
            stream.Write(DateTime.Now + " - " + file + " Named Database Loaded\n");
            stream.Flush();
            stream.Close();
        }

        public static void DatabaseCreated(string file)
        {
            StreamWriter stream = File.AppendText("Log.txt");
            stream.Write(DateTime.Now + " - " + file + " Named Database Created\n");
            stream.Flush();
            stream.Close();
        }
    }
}
