using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory();
            string[] names = Directory.GetFiles(directory);

            Dictionary<string, Dictionary<string, double>> filesData =
                new Dictionary<string, Dictionary<string, double>>();

            foreach (var item in names)
            {
                FileInfo fileInfo = new FileInfo(item);
                string extren = fileInfo.Extension;
                long sizeOriginal = fileInfo.Length;
                double size = Math.Round(sizeOriginal / 1024.0, 3);

                if (!filesData.ContainsKey(extren))
                {
                    filesData.Add(extren, new Dictionary<string, double>());
                }
                filesData[extren].Add(fileInfo.Name, size);
            }
            List<string> list = new List<string>();

            foreach (var item in filesData
                .OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                list.Add(item.Key);

                foreach (var file in item.Value.OrderBy(k => k.Value))
                {
                    list.Add($"--{file.Key} - {file.Value}kb");
                }
            }
            string path = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");
            File.WriteAllLines(path,list);
        }
    }
}
