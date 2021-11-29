using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineManagement
{
    class Beneficiary
    {
        public static int registrationNumber = 1001;
       

        public string Name { get; set; }

        public long Mobilenumber { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public List<Beneficiary> VaccinationDetails { get; set; }


       public static List<int> idlist = new List<int>();
        /// <summary>
        ///  Beneficiary constructor stores all the parameters and write the details of the beneficiary
        /// </summary>
        /// <param name="name">Name of Beneficiary</param>
        /// <param name="mob_no">Mobile Number of Beneficiary</param>
        /// <param name="city">City of Beneficiary</param>
        /// <param name="age">Age of Beneficiary </param>
        /// <param name="gender">Gender of Beneficiary</param>
        public Beneficiary(string name, long mob_no, string city, int age, string gender)
        {
            this.Name = name;
            this.Mobilenumber = mob_no;
            this.City = city;
            this.Age = age;
            this.Gender = gender;
            registrationNumber =  registrationNumber + 1;
            idlist.Add(registrationNumber);
            
            Console.WriteLine($"Name is {Name} , Mobile Number is {Mobilenumber}, City is {City}, Age is {Age} , Gender is {Gender} ");
            Console.WriteLine("registration number is " + registrationNumber);
            

        }


       
    }
}
