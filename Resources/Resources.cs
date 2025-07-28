using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resources
{
    public class Resources
    {
        //Values sets the gets the fvalues for the resource for the Moon Base
        public int Oxygen { get; set; } = 50;
        public int Food { get; set; } = 50;
        public int Water { get; set; } = 50;
        public int Ore { get; set; } = 25;
        public int Total_Workers { get; set; } = 10;
        public CurrentWorker CurrentWorkers = new CurrentWorker();
        public SolarPower Solar = new SolarPower();
        public int PowerUsed = 0;
        
        //Sub Class for Current Workers
        public class CurrentWorker
        {
            public int Minners { get; set; } = 0;
            public int ProcessingWorkers { get; set; } = 0;
            public int Farmers { get; set; } = 0;
        }
        //Sub Class for Solar Power

        public class SolarPower 
        {
            public int level { get; set; } = 1;
            public int Production { get; set; } = 25;
            public int NextUpgradeLevl = 2;
            public int UpgradeTime { get; set; } = 10;
            
        }

        public int Power() 
        {
            int PowerTotal = Solar.Production - PowerUsed; 
            return PowerTotal;
        }

        // Returns the Current Active Works Assigned Jobs in the Base
        public int ActiveWorkers()
        {
            int Total = CurrentWorkers.Minners + CurrentWorkers.ProcessingWorkers + CurrentWorkers.Farmers;
            return Total;
        }
        // Returns the Current Free Works not Assigned to Jobs in the Base
        public int OpenWorkers()
        {
            return Total_Workers - ActiveWorkers();
        }

    }
}
