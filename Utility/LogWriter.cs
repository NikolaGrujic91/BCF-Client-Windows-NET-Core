using System;
using System.IO;
using System.Reflection;

namespace BIMcollab_BCF_WPF_MVVM.Utility
{
    public static class LogWriter
    {
        private static readonly string fileName = "BCF_Client_Log.txt";

        public static void LogWrite(string logMessage)
        {
            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            try
            {
                using (StreamWriter w = File.AppendText(exePath + "\\" + fileName))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception e)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine($"{e.Message}{Environment.NewLine}{e.StackTrace}");
#endif
            }
        }

        private static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write($"{Environment.NewLine}Log Entry : ");
                txtWriter.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine($"  :{logMessage}");
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception e)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine($"{e.Message}{Environment.NewLine}{e.StackTrace}");
#endif
            }
        }
    }
}
