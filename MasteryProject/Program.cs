using System;
using System.Collections.Generic;

namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();

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
                    Console.WriteLine("\n1. Select an employee to pay");
                    Console.WriteLine("\n2. Select a receptionist to take a call");
                    Console.WriteLine("\n3. Select a janitor to sweep the floors");
                    
                

                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("The hospital patients are:");
                    hospital.ShowAllPatients();
                    Console.WriteLine("\n1. View patient status");                    
                }

            }
            while (inMenu);
                                             
        }
        
    }
}
