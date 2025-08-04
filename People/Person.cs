using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; } = int.MinValue;
        public string Status { get; set; } = string.Empty;

        //Constructor for the Person
        public Person(string firstName, string lastName, string sex,DateTime dob)
        {
            //Set the Properties with data
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            DOB = dob;
            Age = GetAge();
        }


        //Calulate Person Age Based on the DOB to current Date Time
        public int GetAge() 
        {
            var today = DateTime.Today;
            Age = today.Year - DOB.Year;
            if (today.Month < DOB.Month || (today.Month == DOB.Month && today.Day < DOB.Day))
            {
                Age--;
            }
            //Updates the Status Age
            Status = GetAgeStatus();
            return Age;
        }

        //Calulate Person Age Based on the DOB on provided Date
        public int GetAge(DateTime caculateDate)
        {
            int age = 0;
            age = caculateDate.Year - DOB.Year;
            if (caculateDate.Month < DOB.Month || (caculateDate.Month == DOB.Month && caculateDate.Day < DOB.Day))
            {
                age--;
            }
            return age;
        }
        // Sets if the Person is a Child or and Adult.
        private string GetAgeStatus() 
        {
            if (Age < 9) { Status = "Child"; }
            else if (Age <= 13 && Age < 18) { Status = "Teen"; }
            else if (Age >= 18 && Age <= 64) { Status = "Adult"; }
            else if (Age > 64) { Status = "Senor"; }
            return Status;
        }

        public string SayHello() 
        {
            return $"{FirstName} Welcomes you to the the MoonBase";
        }


    }
}
