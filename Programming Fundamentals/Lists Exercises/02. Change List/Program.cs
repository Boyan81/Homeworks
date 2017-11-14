using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main()
        {
            List < long > list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            string intComand = Console.ReadLine();
                
            while (intComand != "Odd" || intComand != "Even")
            {
                string[]comand = intComand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (comand[0]== "Delete")
                {
                    var element = long.Parse(comand[1]);
                    list.RemoveAll(match: x => x==element);
                }
                else if (comand[0] == "Insert")
                {
                    var element = long.Parse(comand[1]);
                    var pos = int.Parse(comand[2]);
                    list.Insert(pos,element);
                }
                if (intComand== "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i]%2==1)
                        {

                        Console.Write(list[i]+" ");
                            
                        }
                    }
                    Console.WriteLine();
                    //break;
                }
                else if (intComand == "Even")
                {
                    for (int i = 0; i < list.Count; i ++)
                    {
                        if (list[i]%2==0)
                        {
                        Console.Write(list[i] + " ");
                        }
                    }
                    //Console.WriteLine(list[list.Count]);
                    Console.WriteLine();
                   // break;
                }
                intComand = Console.ReadLine();
               
            }
        }
    }
}
