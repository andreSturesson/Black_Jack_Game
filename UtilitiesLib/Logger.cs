using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{
    public class Logger
    {
        private string path = string.Empty;
        public Logger(string logMessage)
        {
            LogWrite(logMessage);
        }
        public void LogWrite(string logMessage)
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(path + "\\" + "log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Log(string logMessage, TextWriter write)
        {
            try
            {
                write.Write("\r\nLog Entry : ");
                write.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                write.WriteLine("  :{0}", logMessage);
                write.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
