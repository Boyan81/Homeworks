﻿using System;
using System.IO;
using System.Collections.Generic;
namespace _05._Slicing_File
{
    class Program
    {
        private const int bufferSize = 4096;
        static void Main()
        {
            string sourceFile = "../Resources/sliceMe.mp4";
            string destinationDirectory = "";
            int parts = 5;
            Slice(sourceFile, destinationDirectory, parts);
            List<string> files = new List<string>
            {
                "Part-0.mp4",
                "Part-1.mp4",
                "Part-2.mp4",
                "Part-3.mp4",
                "Part-4.mp4",
            };
            Assemble(files, destinationDirectory);
        }
        static void Slice(string sourceFile, string destinationDirectory, int parts)
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
                    string curentPart = destinationDirectory + $"Part-{i}." + extention;
                    using (FileStream write = new FileStream(curentPart, FileMode.Create))
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
        static void Assemble(List<string> files, string destinationDirectory)
        {

            string extention = files[0].Substring(files[0].LastIndexOf('.') + 1);

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
                    using (FileStream reader = new FileStream(file,FileMode.Open))
                    {
                        while (reader.Read(buffer,0,bufferSize)==bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);
                        }
                    }

                }
            }
        }
    }
}
