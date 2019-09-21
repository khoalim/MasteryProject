using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Janitor : Employee
    {
        
        public int Sweeping { get; set; }


        public Janitor(string name, string number, int salary) : base(name, number, salary)
        {
           
        }

        public Janitor()
        {
            Sweeping = 0;
        }      


        ////public override void DrawBlood(Patient patient)
        ////{
        ////    Console.WriteLine("This employee is not authorized to work on patients!");
        ////}

        ////public override void CarePatient(Patient patient)
        ////{
        ////    Console.WriteLine("This employee is not authorized to work on patients!");
        ////}

        public override void ShowInfo()
        {
            Console.WriteLine($"Janitor:{Name}, {Number}, ${Salary}");
        }
        
        public void CheckSweepingStatus()
        {
            Console.Clear();
            Sweeping++;
            if (Sweeping % 2 == 1)
            {
                Console.WriteLine("All the janitors are sweeping");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }

            if (Sweeping % 2 == 0)
            {
                Console.WriteLine("All the janitors are not sweeping");
                Console.WriteLine("\nTo make janitors sweep up press 'R'");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }
        }

    }
}
    
       
    


