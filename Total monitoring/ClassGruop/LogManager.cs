using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SmithLibrary.Tools
{
    

    public class LogManager
    {
        public enum LogType { Daily, Monthly }

        public string _path;

        #region Constructors(생성자)
        public LogManager(string path, LogType logType, string prefix, string postfix)
        {
            _path = path;
            _SetLogPath(logType, prefix, postfix);
        }

        public LogManager(string prefix, string postfix)
            : this(Path.Combine(BasicClass.Root, "Log"), LogType.Daily, prefix,postfix)
        {

        }

        public LogManager()
            : this(Path.Combine(BasicClass.Root, "Log"), LogType.Daily, null, null)
        {
        }
        #endregion

        #region Methods
        private void _SetLogPath(LogType logType, string prefix, string postfix)
        {
            string path = string.Empty;
            string name = string.Empty;

            switch (logType)
            {
                case LogType.Daily:
                    path = string.Format(@"{0}\{1}\", DateTime.Now.Year, DateTime.Now.ToString("MM"));
                    name = DateTime.Now.ToString("yyyyMMdd");
                    break;
                case LogType.Monthly:
                    path = string.Format(@"{0}\", DateTime.Now.Year);
                    name = DateTime.Now.ToString("yyyyMM");
                    break;
                default:
                    break;
            }

            _path = Path.Combine(_path, path);
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            if (!string.IsNullOrEmpty(prefix))
                name = prefix + name;
            if (!string.IsNullOrEmpty(postfix))
                name = name + postfix;
            name += ".txt";

            _path = Path.Combine(_path, name);
        }

        public void Write(string data)
        {
            try
            {
                // using 함수를 벗어나면 리소스를 해제 -> 메모리 관리에 좋다
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.Write(data);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        public void WriteLine(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss \t") + data);
                }
            }
            catch (Exception ex)
            {}            
        }

        public void WriteConsole(string data)
        {
            Write(data);
            Console.WriteLine(data);
        }
        #endregion
    }
}
