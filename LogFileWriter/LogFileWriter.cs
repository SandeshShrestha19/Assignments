using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFileWriter
{
    public class LogFileWriter
    {
        private string LogFilePath;

        public LogFileWriter(string logFilePath)
        {
            this.LogFilePath = logFilePath;
        }
        public void WriteLog(TypeOfLevel typeOfLevel, string message)
        {
            try
            {
                string logInput = $"{DateTime.UtcNow} [{typeOfLevel}] {message}";
                File.AppendAllText(LogFilePath, $"{logInput}\n");
            }
            catch( Exception ex )
            {
                Console.WriteLine($"Failed to enter data: {ex.Message}");
            }
            
        }
    }
}
