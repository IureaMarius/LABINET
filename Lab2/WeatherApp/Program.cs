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


            IEnumerable<Dictionary<string, ColumnValue>>result = TableParser.ParseTable(config);

        }
    }
}
