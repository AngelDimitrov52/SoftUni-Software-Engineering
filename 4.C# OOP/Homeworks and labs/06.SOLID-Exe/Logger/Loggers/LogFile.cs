using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SOLID.Loggers
{
    public class LogFile : ILogFile
    {
        private string path = "../../../log.txt";
        public int Size => File.ReadAllText(path)
            .Where(s => char.IsLetter(s))
            .Sum(s => s);

        public void Write(string append)
        {
            File.AppendAllText(path, append);
        }
    }
}
