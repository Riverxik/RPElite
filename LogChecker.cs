using System;
using System.IO;
using System.Threading;

namespace RPElite
{
    class LogChecker
    {
        private const string _elitePath = "\\Saved Games\\Frontier Developments\\Elite Dangerous\\";
        private const int CHECK_DELAY = 5000;

        public EventHandler<LogEvent> newEntryHandler;
        public FileStream fs;
        public StreamReader sr;

        public LogChecker()
        {
            fs = new FileStream("test.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            sr = new StreamReader(fs, System.Text.Encoding.Default);
        }

        public void readLog()
        {
            string line;
            while ((line = sr.ReadLine()) != null && !line.Equals(""))
            {
                newEntryHandler.Invoke(this, new LogEvent(line));
            }
        }
    }

    class LogEvent : EventArgs
    {
        private string _logEntry;
        public LogEvent(string entry)
        {
            this._logEntry = entry;
        }

        public string GetString() { return _logEntry; }
    }
}
