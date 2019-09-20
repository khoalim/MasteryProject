using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Janitor : Employee
    {
        bool SweepingStatus { get; set; }


        public Janitor(string name, string number, int salary) : base(name, number, salary)
        {
            
        }

        public override void DrawBlood(Patient patient)
        {
            Console.WriteLine("This employee is not authorized to work on patients!");
        }

        public override void CarePatient(Patient patient)
        {
            Console.WriteLine("This employee is not authorized to work on patients!");
        }
    }
}
