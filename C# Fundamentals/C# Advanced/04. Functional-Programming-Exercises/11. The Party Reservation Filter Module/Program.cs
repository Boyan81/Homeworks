using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main()
        {
            List<string> gams = Console.ReadLine().Split()
                .ToList();
            Dictionary<string, Func<List<string>, List<string>>> filters = new Dictionary<string, Func<List<string>, List<string>>>();

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                ParseCommand(command, filters);
            }
            List<string> filtred = GetFiltred(gams, filters);
            gams = gams.Where(gem => !filtred.Contains(gem)).ToList();
            Console.WriteLine(String.Join(" ", gams));
        }

        private static List<string> GetFiltred(List<string> gams, Dictionary<string, Func<List<string>, List<string>>> filters)
        {
            List<string> filtred = new List<string>();
            foreach (var item in filters)
            {
                var filter = item.Value;
                filtred.AddRange(filter(gams));
            }
            return filtred;
        }

        private static void ParseCommand(string commandInput, Dictionary<string, Func<List<string>, List<string>>> filters)
        {
            string[] tokens = commandInput.Split(';');
            string command = tokens[0];
            string filterType = tokens[1];
            string parameter = tokens[2];
            string dictKey = $"{filterType} {parameter}";
            if (command == "Add filter")
            {

                filters[dictKey] = CreatFunction(filterType, parameter);// filters.Add(dictKey, CreatFunction(filterType, parameter));//

            }
            else if (command == "Remove filter")
            {

                filters.Remove(dictKey);

            }
        }

        private static Func<List<string>, List<string>> CreatFunction(string filterType, string parameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    return gems => gems.Where(gem=> 
                    {
                        return gem.StartsWith(parameter);
                    }).ToList();
                   
                case "Ends with":
                    return gems => gems.Where(gem =>
                    {
                        return gem.EndsWith(parameter);
                    }).ToList();
                case "Contains":
                    return gems => gems.Where(gem =>
                    {
                        return gem.Contains(parameter);
                    }).ToList();
                case "Length":
                    return gems => gems.Where(gem =>
                    {
                        int length = int.Parse(parameter);
                        return gem.Length==length;
                    }).ToList();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
