using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            int cmdCount = int.Parse(Console.ReadLine());
            var steck = new Stack<string>();
            steck.Push("");
            StringBuilder curentText = new StringBuilder();

            for (int i = 0; i < cmdCount; i++)
            {
                string[] inputComands = Console.ReadLine().Split();
                int cmd = int.Parse(inputComands[0]);
                switch (cmd)
                {
                    case 1:
                        steck.Push(curentText.ToString());
                        curentText.Append(inputComands[1].ToString());
                        break;
                    case 2:
                        steck.Push(curentText.ToString());
                        int lenght = int.Parse(inputComands[1]);
                        curentText.Remove(curentText.Length - lenght, lenght);
                        break;
                    case 3:
                        int index = int.Parse(inputComands[1]);
                        Console.WriteLine(curentText[index-1]);
                        break;
                    case 4:
                        curentText.Clear();
                        curentText.Append(steck.Pop());
                        break;
                }
            }
        }
    }
}
