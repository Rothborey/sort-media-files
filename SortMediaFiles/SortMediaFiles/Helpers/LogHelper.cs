﻿namespace SortMediaFiles.Helpers
{
	public static class LogHelper
    {      
        public static void LogMessageToFile(string msg, string logPath)
        {
            System.IO.StreamWriter sw = System.IO.File.AppendText(
				logPath + "Log.txt");
            try
            {
                string logLine = System.String.Format(
                    "{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
