using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> departaments = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            string input = "";
            while ((input = Console.ReadLine().Trim()) != "Output")
            {
                string[] patienData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string depart = patienData[0];
                string doctor = patienData[1] + " " + patienData[2];
                string patient = patienData[3];

                if (!departaments.ContainsKey(depart))
                {
                    departaments.Add(depart, new List<string>());
                    
                }
                departaments[depart].Add(patient);
                if (!doctors.ContainsKey(doctor))
                {
                    doctors.Add(doctor, new List<string>());
                    
                }
                doctors[doctor].Add(patient);
            }
            while ((input = Console.ReadLine().Trim()) != "End")
            {
                string[] splitCmd = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (splitCmd.Length==1)
                {
                    foreach (var item in departaments[splitCmd[0]])
                    {
                        Console.WriteLine(item);
                    }
                }
                else 
                {
                    int roomNumber = 0;

                    if (int.TryParse(splitCmd[1],out roomNumber))
                    {
                        var skip = 3 * (roomNumber - 1);
                        foreach (var item in departaments[splitCmd[0]].Skip(skip).Take(3).OrderBy(p=>p))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        foreach (var item in doctors[input].OrderBy(p=>p))
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}
