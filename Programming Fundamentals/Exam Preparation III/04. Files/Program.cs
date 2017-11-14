using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        private static void AddRoots(List<Root> roots)
        {
            string[] input = Console.ReadLine().Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string directoryName = input[0];
            string fileName = input[input.Length - 2];
            long fileSize = long.Parse(input.Last());
            foreach (var root in roots)
            {
                if (root.Name == directoryName)
                {
                    if (root.Files.Keys.Contains(fileName))
                    {
                        root.Files[fileName] = fileSize;
                        return;
                    }
                    root.Files.Add(fileName, fileSize);
                    return;
                }
            }
            roots.Add(new Files.Root
            {
                Name = directoryName,
                Files = new Dictionary<string, long>()
                {
                    { fileName, fileSize }
                }
            });
        }

        private static void PrintFiles(List<Root> roots, string[] searchFor)
        {
            string rootName = searchFor[1].Trim();
            string fileName = searchFor[0].Trim();
            bool isEmpty = true;
            foreach (var root in roots.Where(x => x.Name == rootName))
            {
                foreach (var file in root.Files.Where(x => Path.GetExtension(x.Key).Contains(fileName))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            int rootNums = int.Parse(Console.ReadLine());
            List<Root> roots = new List<Root>();
            for (int i = 0; i < rootNums; i++)
            {
                AddRoots(roots);

            }
            string[] searchFor = Console.ReadLine().Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            PrintFiles(roots, searchFor);
        }
    }

    class Root
    {
        public string Name { get; set; }
        public Dictionary<string, long> Files { get; set; }
    }
}
