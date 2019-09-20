using System;
using System.Collections.Generic;

namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();
            hospital.AddEmployees();
            hospital.AddPatients();

            Console.WriteLine("Welcome to University Clinic Hospital!");
            Console.WriteLine("**************************************");
            Console.WriteLine("What would you like to do?");       
                  
            

            bool inMenu = true;
            
            do
            {
                Console.WriteLine("\nPress '1' for list of Hospital employees");
                Console.WriteLine("\nPress '2' for list of Hospital patients");

                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (userInput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("The hospital employees are:");
                    hospital.ShowAllEmployees();
                    //Console.WriteLine("\nPress 3. Select a receptionist to take a call");
                    //Console.WriteLine("\nPress 4. Select a janitor to sweep the floors");
                    Console.WriteLine("\nPress 3. Pay Employees");
                    Console.WriteLine("\nPress 0. Return to Main Menu");
                   

                    switch (userInput)
                    {
                        case 3:
                        hospital.AllPayEmployees();
                        break;
                        
                        //Console.ReadLine();
 
                    }




                

                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("The hospital patients are:");
                    hospital.ShowAllPatients();
                    Console.WriteLine("\n1. View patient status");
                    //Console.WriteLine("\n2. Select a nurse);
                }

            }
            while (inMenu);
                                             
        }
        
    }
}
