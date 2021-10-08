using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Utils.DataObjects
{
    public class TableParserConfig
    {
        public string[] Separators { get; set; }
        public string IgnoreChars { get; set; }
        public string FilePath { get; set; }
    }
}
