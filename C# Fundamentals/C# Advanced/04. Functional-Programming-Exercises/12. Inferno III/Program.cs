using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Inferno_III
{
    class Program
    {
        static void Main()
        {
            List<int> gams = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            Dictionary<string, Func<List<int>, List<int>>> filters = new Dictionary<string, Func<List<int>, List<int>>>();

            string command;
            while ((command = Console.ReadLine()) != "Forge")
            {
                ParseCommand(command, filters);
            }
            List<int> filtred = GetFiltred(gams, filters);
            gams = gams.Where(gem => !filtred.Contains(gem)).ToList();
            Console.WriteLine(String.Join(" ",gams));
        }

        private static List<int> GetFiltred(List<int> gams, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            List<int> filtred = new List<int>();
            foreach (var item in filters)
            {
                var filter = item.Value;
                filtred.AddRange(filter(gams));
            }
            return filtred;
        }

        private static void ParseCommand(string commandInput, Dictionary<string, Func<List<int>, List<int>>> filters)
        {
            string[] tokens = commandInput.Split(';');
            string command = tokens[0];
            string filterType = tokens[1];
            int parameter = int.Parse(tokens[2]);
            string dictKey = $"{filterType} {parameter}";
            if (command == "Exclude")
            {
               
                   filters[dictKey]= CreatFunction(filterType, parameter);// filters.Add(dictKey, CreatFunction(filterType, parameter));//
                
            }
            else if (command == "Reverse")
            {
               
                    filters.Remove(dictKey);
               
            }
        }

        private static Func<List<int>, List<int>> CreatFunction(string filterType, int parameter)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int leftGem = index > 0 ? gems[index - 1] : 0;
                        return gem + leftGem == parameter;
                    }).ToList();
                case "Sum Right":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int rightGem = index <gems.Count-1 ? gems[index + 1] : 0;
                        return gem + rightGem == parameter;
                    }).ToList();
                case "Sum Left Right":
                    return gems => gems.Where(gem =>
                    {
                        int index = gems.IndexOf(gem);
                        int leftGem = index > 0 ? gems[index - 1] : 0;
                        int rightGem = index < gems.Count - 1 ? gems[index + 1] : 0;
                        return leftGem +gem + rightGem == parameter;
                    }).ToList();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
