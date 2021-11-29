using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineManagement
{
    class Program
    {

       
        static void Main(string[] args)
        {
            List<Beneficiary> beneficiarylist = new List<Beneficiary>();
            var beneficiary1 = new Beneficiary("Gunal", 9876126734, "Chennai", 18, "Male");
            beneficiarylist.Add(beneficiary1);
            var beneficiary2 = new Beneficiary("Raj", 8587345121, "Trichy", 21, "Male");
            beneficiarylist.Add(beneficiary2);

            Beneficiary member3;

            Vaccination vaccination = new Vaccination();

            List<Vaccination> vaccinationlist = new List<Vaccination>();

            //int flag = 0;

            string opinion,repeat=" ";
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Welcome to Covid Vaccination Center");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.Enter new beneficiary details \n 2.Vaccine Details \n 3.Exit");
                Console.WriteLine("Please Enter your choice");
                Console.WriteLine("---------------------------------------");
                char choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Enter your Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your Mobile number");
                        long phonenumber = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your City");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter your Age");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Gender");
                        string gender = Console.ReadLine();
                        member3 = new Beneficiary(name, phonenumber, city, age, gender);
                        beneficiarylist.Add(member3);
                        break;

                    case '2':

                        Console.WriteLine("Vaccination");
                        Console.WriteLine("Enter the registration id");
                        int registrationvalue = int.Parse(Console.ReadLine());

                        foreach (int sid in Beneficiary.idlist)
                        {
                            if (sid == registrationvalue )
                            {
                                do
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Main menu");
                                    Console.WriteLine("a,Take vaccination \n b,Vaccination History \n c,Next Due Date \n d,Exit");
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Please enter the option a,b,c,d");
                                    char option = Console.ReadLine()[0];

                                    switch (option)
                                    {
                                        case 'a':
                                            Console.WriteLine("Take your Vaccination");

                                            vaccination.Dosage = 0;
                                            Console.WriteLine("Enter the dose type");
                                            int dosetype = int.Parse(Console.ReadLine());
                                            if (dosetype == 1)
                                            {
                                                Console.WriteLine($"Your vaccine is {Vaccination.Dosetype.Covishield}");
                                            }
                                            else if (dosetype == 2)
                                            {
                                                Console.WriteLine($"Your vaccine is {Vaccination.Dosetype.Covaxin}");
                                            }

                                            break;

                                        case 'b':
                                            Console.WriteLine("Vaccination History");
                                            vaccination.VaccineDetails();
                                            Console.WriteLine("Your Vaccination date and Time " + DateTime.Now);
                                            break;

                                        case 'c':
                                            Console.WriteLine("Next Due Date");
                                            Console.WriteLine("Your due date is " + DateTime.Now.AddDays(90));
                                            break;

                                        case 'd':
                                            System.Environment.Exit(0);
                                            break;
                                    }
                                    Console.WriteLine("Do you wish to continue to go Vaccination main menu yes/no ");
                                    repeat = Console.ReadLine();

                                } while (repeat.ToLower() == "yes" && repeat.ToLower() != "no");

                                if(repeat.ToLower() == "no")
                                {
                                    break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Your id is not present please register!");
                                break;
                            }


                        }
                        
                               
                            
                        
                        break;

                    case '3':
                        System.Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you wish to continue the process of registration yes/no ");
                opinion = Console.ReadLine();
            } while (opinion.ToLower() == "yes");
            
           
        }
    }
}
