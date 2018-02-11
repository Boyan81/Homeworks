using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int startingPosition = int.Parse(Console.ReadLine());
            string comands;
            int substract = 1;
            while ((comands = Console.ReadLine()) != "Supernova")
            {
                string[] comand = comands.Split();
                string cmd = comand[0];
                int index = int.Parse(comand[1]);
                switch (cmd)
                {
                    case "left":
                        //Left(sequence, index,startingPosition,substract);
                        while (index-- > 0)
                        {
                            if (startingPosition == 0)
                            {
                                startingPosition = sequence.Length - 1;
                                substract++;
                                sequence[startingPosition] -= substract;
                                continue;
                            }
                            startingPosition--;
                            sequence[startingPosition] -= substract;

                        }
                        break;
                    case "right":
                        //Right(sequence, index, startingPosition, substract);
                        while (index-- > 0)
                        {
                            if (startingPosition == sequence.Length - 1)
                            {
                                startingPosition = 0;
                                substract++;
                                sequence[startingPosition] -= substract;
                                continue;
                            }
                            startingPosition++;
                            sequence[startingPosition] -= substract;

                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", sequence));

        }




    }
}
