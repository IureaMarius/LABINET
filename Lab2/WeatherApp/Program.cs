using BusinessLogic.Utils;
using BusinessLogic.Utils.DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TableParserConfig config = new TableParserConfig();
            config.FilePath = ConfigurationManager.AppSettings["filePath"];
            config.Separators = ConfigurationManager.AppSettings["separatorChars"].Split(',');
            config.IgnoreChars = ConfigurationManager.AppSettings["ignoredChars"];


            List<Dictionary<string, ColumnValue>> result = TableParser.ParseTable(config);

            result.RemoveAt(result.Count - 1);
            int minDifference = Int32.MaxValue;
            int minDifferenceIndex = -1;
            foreach(Dictionary<string, ColumnValue> line in result)
            {
                int difference = Math.Abs(Int32.Parse(line.GetValueOrDefault("MxT").Value) - Int32.Parse(line.GetValueOrDefault("MnT").Value));
                if(difference < minDifference)
                {
                    minDifference = difference;
                    minDifferenceIndex = Int32.Parse(line.GetValueOrDefault("Dy").Value);
                }
            }
            Console.WriteLine(minDifference);
            Console.WriteLine(minDifferenceIndex);
        }
    }
}
