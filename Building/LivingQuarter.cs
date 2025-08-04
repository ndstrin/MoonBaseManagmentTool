using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class LivingQuarter : Building
    {
        public int NumberOfPeople { get; set; } = 0;
        public int MaxNumberOfPeople { get; set; } = 5;



        public LivingQuarter(string name, string description, int number)
: base(name, description,number)
        {

            

        }



        // Gets if there is room in the living Quarter
        public bool RoomAvailable()
        {
            if (NumberOfPeople == MaxNumberOfPeople) { return false; }
            else { return true; }
        }
        //Returns if the Living Quarters is Empty or Not
        public bool QuartersEmpty() 
        {
            if (NumberOfPeople == 0) { return true; }
            else{ return false; }
        }


    }


}
