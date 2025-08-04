using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Building
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Number {  get; set; }
        public Double Cost { get; set; } = 100;
        public int Level { get; set; } = 1;
        public bool Upgradeable { get; set; } = false;
        
        //Intial Constructior for Parent Class
        public Building(string name,string description, int number) 
        {
            Name = name;
            Description = description; 
            Number = number;
        }







    }






   


}
