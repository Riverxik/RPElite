using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace RPElite
{
    class LogChecker
    {
        private const string _elitePath = "\\Saved Games\\Frontier Developments\\Elite Dangerous\\";
        public static int part = 1;

        public EventHandler<LogEvent> newEntryHandler;
        public FileStream fs;
        public StreamReader sr;

        public LogChecker()
        {
            string filename = GetCorrectFilename();
            if (filename == null || Program.isDebug) filename = "test.log";
            Console.WriteLine(filename);
            fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            sr = new StreamReader(fs, System.Text.Encoding.UTF8);
        }

        private string GetCorrectFilename()
        {
            // Example: Journal.21 05 25 22:11:51.01 = Journal.210525221151.01
            DateTime timeNow = DateTime.Now;
            string timePattern = @"yyMMddHHmmss";
            string time = timeNow.ToString(timePattern, System.Globalization.CultureInfo.InvariantCulture);
            string shouldLog = string.Format("Journal.{0}.0{1}", time, part);
            string fileMask = shouldLog.Substring(0, shouldLog.Length - 7);
            Regex searchPattern = new Regex(fileMask);
            string userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = userprofile + _elitePath;
            string[] files = Directory.GetFiles(fullPath).Where(f => searchPattern.IsMatch(f)).ToArray();
            if (files.Length == 0) return "test.log";
            return files[0];
        }

        public void ReadLog()
        {
            string line;
            if (sr == null) throw new InvalidOperationException("Can't read logfile");
            while ((line = sr.ReadLine()) != null && !line.Equals(""))
            {
                newEntryHandler.Invoke(this, new LogEvent(line));
            }
        }
    }

    class LogEvent : EventArgs
    {
        private readonly string _logEntry;
        public LogEvent(string entry)
        {
            this._logEntry = entry;
        }

        public string GetString() { return _logEntry; }
    }
}
