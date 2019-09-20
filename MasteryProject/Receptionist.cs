using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    class Receptionist : Employee
    {
        public bool PhoneStatus { get; set; }
       

        public Receptionist (string name, string number, int salary) : base(name, number, salary)
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
