using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace People
{
    public class Crew : Person
    {
        public string JobTile { get; set; }
        public int IdNumber { get; set; }
        public string Rank { get; set; }   



        public Crew(string firstname, string lastName, string jobTile, int idNumber, string sex, DateTime dob, string rank)
: base(firstname, lastName,sex,dob)
        {
            IdNumber = idNumber;
            JobTile = jobTile;  
            Rank = rank;

        }




    }

    

}
