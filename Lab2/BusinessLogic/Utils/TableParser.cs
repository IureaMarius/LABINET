using BusinessLogic.Utils.DataObjects;
using BusinessLogic.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Utils
{
    public static class TableParser
    {
        public static IEnumerable<Dictionary<string, ColumnValue>> ParseTable(TableParserConfig config)
        {
            IEnumerable<string> lines = System.IO.File.ReadLines(config.FilePath);

            string[] columnHeadings = lines.First().Split((char[])null);
            List<Dictionary<string, ColumnValue>> result = new List<Dictionary<string, ColumnValue>>();
            foreach (string line in lines.Skip(1))
            {
                if (String.IsNullOrEmpty(line))
                    continue;
                Dictionary<string, ColumnValue> columnDict = new Dictionary<string, ColumnValue>();
                string[] columns = line.Split((char[])null);
                int i = 0;
                foreach(string column in columns)
                {

                    string columnString = column.RemoveCharacters(config.IgnoreChars);
                    ColumnValue columnValue = new ColumnValue();
                    columnValue.Value = columnString;
                    if(Int32.TryParse(columnString, out int columnIntValue))
                    {
                        columnValue.ValueType = ColumnValueType.Integer;
                    }else if(double.TryParse(columnString, out double columnDoubleValue)) {
                        columnValue.ValueType = ColumnValueType.Double;
                    }else if(Boolean.TryParse(columnString, out bool columnBoolValue))
                    {
                        columnValue.ValueType = ColumnValueType.Boolean;
                    }else
                    {
                        columnValue.ValueType = ColumnValueType.String;
                    }

                    columnDict.Add(columnHeadings[i], columnValue);
                    i++;
                }
                result.Add(columnDict);

            }
            return result;
        }

    }
}
