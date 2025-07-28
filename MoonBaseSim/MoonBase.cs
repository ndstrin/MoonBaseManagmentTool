using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonBaseSim
{
    internal class MoonBase
    {
        //Overall Class for Game Stats
        public int Level { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public int EXP { get; set; } = 0;
        public int Next_Level_EXP { get; set; } = 300;

    }

    
}
