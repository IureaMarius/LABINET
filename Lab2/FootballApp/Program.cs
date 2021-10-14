using BusinessLogic.Utils;
using BusinessLogic.Utils.DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace FootballApp
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
            string teamName = null;
            foreach(Dictionary<string, ColumnValue> line in result)
            {
                int difference = Math.Abs(Int32.Parse(line.GetValueOrDefault("F").Value) - Int32.Parse(line.GetValueOrDefault("A").Value));
                if(difference < minDifference)
                {
                    minDifference = difference;
                    teamName = line.GetValueOrDefault("Team").Value;
                }
            }
            Console.WriteLine(minDifference);
            Console.WriteLine(teamName);
        }
    }
}
