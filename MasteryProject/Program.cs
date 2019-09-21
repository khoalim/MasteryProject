using System;
using System.Collections.Generic;

namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();
            Employee employee = new Employee();
            hospital.AddEmployees();
            hospital.AddPatients();            
            hospital.MainMenu();
            Doctor Doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            Patient patient = new Patient();

            bool inHospitalMenu = true;
            
            while (inHospitalMenu)
            {
               
                string userInput= Console.ReadLine().ToLower();


                switch (userInput)
                {
                    case "m":
                        Console.Clear();
                        hospital.MainMenu();
                        break;

                    case "1":
                        Console.Clear();
                        Console.WriteLine("The hospital employees are:");
                        hospital.ShowAllEmployees();

                        Console.WriteLine("\nPress 'P' to view Payroll Status");
                        Console.WriteLine("\nPress 'J' to view Janitors' Status");
                        Console.WriteLine("\nPress 'R' to view Receptionists' Status");
                        Console.WriteLine("\nPress 'M' to return to Main Menu");
                        break;

                    case "p":
                        employee.PayEmployee();
                        break;

                    case "r":
                        receptionist.CheckPhoneStatus();
                        break;

                    case "j":
                        janitor.CheckSweepingStatus();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("The hospital patients are:");
                        hospital.ShowAllPatients();

                        Console.WriteLine("\nPress 'DB' for Doctor to draw patients' blood");
                        Console.WriteLine("\nPress 'DC for Doctor to care for patients");
                        Console.WriteLine("\nPress 'NB' for Nurse to draw patients' blood");
                        Console.WriteLine("\nPress 'NC' for Nurse to care for patients");
                        Console.WriteLine("\nPress 'M' to return to Main Menu");
                        break;

                    case "nb":
                        Console.Clear();
                        nurse.DrawBlood(patient);
                        Console.WriteLine("\nYour patients' new stats are:");
                        hospital.ShowAllPatients();

                        break;
                                            

                    case "3":
                        inHospitalMenu = false;
                        Console.WriteLine("GoodBye! Thanks for Visiting!");
                        break;
                                               
                    default:
                        Console.WriteLine("Invalid Entry. Please Try Again!");
                        break;
                }

            }           
                                             
        }
        
    }
}
