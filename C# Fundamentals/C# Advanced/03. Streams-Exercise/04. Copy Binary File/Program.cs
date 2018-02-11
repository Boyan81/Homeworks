using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        const string ImagePath = "../Resources/copyMe.png";
        const string DestinationPath = "result.txt";

        static void Main()
        {
            using (var source = new FileStream(ImagePath, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath, FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
