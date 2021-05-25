﻿using System;
using System.IO;
using System.Threading;

namespace RPElite
{
    class LogChecker
    {
        private const string _elitePath = "\\Saved Games\\Frontier Developments\\Elite Dangerous\\";

        public EventHandler<LogEvent> newEntryHandler;
        public FileStream fs;
        public StreamReader sr;

        public LogChecker()
        {
            fs = new FileStream("test.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            sr = new StreamReader(fs, System.Text.Encoding.UTF8);
        }

        public void ReadLog()
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
        private readonly string _logEntry;
        public LogEvent(string entry)
        {
            this._logEntry = entry;
        }

        public string GetString() { return _logEntry; }
    }
}
