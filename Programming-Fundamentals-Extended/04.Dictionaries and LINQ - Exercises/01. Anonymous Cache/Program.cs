using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Cache
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, ulong> dataSets= new Dictionary<string, ulong>();
            Dictionary<string, List<string>> dataKeys = new Dictionary<string, List<string>>();
            string input;

            while ((input=Console.ReadLine())!= "thetinggoesskrra")
            {
                string[] tokens = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string dataSet ;
                string dataKey ;
                string dataSize;

                if (tokens.Length>1)
                {
                    dataSet = tokens[2];
                    dataKey = tokens[0];
                    dataSize = tokens[1];
                    if (!dataSets.ContainsKey(dataSet))
                    {
                        dataSets.Add(dataSet, ulong.Parse(dataSize));
                        dataKeys.Add(dataSet, new List<string>());
                        dataKeys[dataSet].Add(dataKey);
                    }
                    else
                    {
                        dataSets[dataSet] += ulong.Parse(dataSize);
                        dataKeys[dataSet].Add(dataKey);
                    }
                }
                else
                {
                    dataSet = tokens[0];

                    if (!dataSets.ContainsKey(dataSet))
                    {
                        dataSets.Add(dataSet, 0);
                        dataKeys.Add(dataSet, new List<string>());
                        //dataKeys[dataSet].Add(dataKey);
                    }
                   
                }
            }
            if (dataSets.Count > 0)
            {
                var maxValue = dataSets.FirstOrDefault(x => x.Value.Equals(dataSets.Values.Max()));
            Console.WriteLine($"Data Set: {maxValue.Key}, Total Size: {maxValue.Value}");
            
                foreach (var item in dataKeys[maxValue.Key])
                {
                    Console.WriteLine($"$.{item}");
                }
            }
        }
    }
}
