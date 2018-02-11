using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace _06._Zipping_Sliced_Files
{
    class Program
    {
        private const int bufferSize = 4096;
        static void Main()
        {
            string sourceFile = "../Resources/sliceMe.mp4";
            string destinationDirectory = "";
            int parts = 5;
            Zipping(sourceFile, destinationDirectory, parts);
            List<string> files = new List<string>
            {
                "Part-0.mp4.gz",
                "Part-1.mp4.gz",
                "Part-2.mp4.gz",
                "Part-3.mp4.gz",
                "Part-4.mp4.gz",
            };
            Assemble(files, destinationDirectory);

        }

       
        private static void Zipping(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream reader = new FileStream(sourceFile, FileMode.Open))
            {
                string extention = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);
                long priceSize = (long)Math.Ceiling((double)reader.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPiceSize = 0;
                    if (destinationDirectory == string.Empty)
                    {
                        destinationDirectory = "./";
                    }
                    string curentPart = destinationDirectory + $"Part-{i}." + extention+".gz";
                    using (GZipStream write = new GZipStream(new FileStream(curentPart, FileMode.Create), CompressionLevel.Optimal))
                    {
                        byte[] buffer = new byte[bufferSize];
                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            write.Write(buffer, 0, bufferSize);
                            currentPiceSize += bufferSize;
                            if (currentPiceSize >= priceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        private static void Assemble(List<string> files, string destinationDirectory)
        {
            string extention = files[0].Substring(files[0].LastIndexOf('.') -3 );
            extention = extention.Substring(0,3);
            if (destinationDirectory == string.Empty)
            {
                destinationDirectory = "./";
            }
            if (!destinationDirectory.EndsWith("/"))
            {
                destinationDirectory += "/";
            }
            string assembleFile = $"{destinationDirectory}Assemble.{extention}";

            using (FileStream writer = new FileStream(assembleFile, FileMode.Create))
            {
                byte[] buffer = new byte[bufferSize];

                foreach (var file in files)
                {
                    using (GZipStream reader =new GZipStream(new FileStream(file, FileMode.Open),CompressionMode.Decompress))
                    {
                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);
                        }
                    }

                }
            }

        }
    }
}
