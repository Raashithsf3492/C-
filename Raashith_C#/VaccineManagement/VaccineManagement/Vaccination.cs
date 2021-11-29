using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineManagement
{
    class Vaccination
    {

        public static int _dosecount = 0;

       
        public int Dosage {
            get
            {
                return _dosecount;
            } 
            set { 

                if(value == 0)
                {
                    _dosecount = 1;
                    
                }

                else if( value == 1)
                {
                    _dosecount = 2;
                }
                else if(value == 3)
                {
                    Console.WriteLine("You are fully Vaccinated! Thanks for your participation");
                }
            }
        }

       
        public void VaccineDetails()
        {
            Console.WriteLine("Your vaccination dose is" + Dosage);
        }
       

        // ENum created for dose type

        public enum Dosetype
        {
            Covishield = 1,
            Covaxin
        }

    }
}
