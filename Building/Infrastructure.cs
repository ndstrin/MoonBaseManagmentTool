using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Infrastructure : Building
    {
        public string Type { get; set; }
        public string SubType { get; set; }
        public int Workers { get; set; } = 0;
        public int ProductionRate { get; set; } = 0;
        public Infrastructure(string name, string description, int number,string type, string subtype)
: base(name, description, number)
        {
            Type = type;
            SubType = subtype;

        }
    }
}
