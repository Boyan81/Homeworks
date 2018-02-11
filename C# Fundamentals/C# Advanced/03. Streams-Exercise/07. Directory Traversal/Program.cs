using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07._Directory_Traversal
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine();
            var filesDictonary = new Dictionary<string, List<FileInfo>>();
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                string extention = fileInfo.Extension;

                if (!filesDictonary.ContainsKey(extention))
                {
                    filesDictonary[extention] = new List<FileInfo>();
                }
                filesDictonary[extention].Add(fileInfo);
            }
            filesDictonary = filesDictonary.OrderByDescending(x => x.Value.Count)
                                .ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFileName = desktop + @"\report.txt";

            using (StreamWriter writer = new StreamWriter(fullFileName))
            {
                foreach (var pair  in filesDictonary)
                {
                    string extention = pair.Key;
                    writer.WriteLine(extention);
                    var fileinfos = pair.Value.OrderByDescending(fi=>fi.Length);

                    foreach (var fileInfo in fileinfos)
                    {
                        double size = (double)fileInfo.Length / 1024;
                        writer.WriteLine($"--{fileInfo.Name} - {size}kb");
                    }
                }
            }

        }
    }
}
