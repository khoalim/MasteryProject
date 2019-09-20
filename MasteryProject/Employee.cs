using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int Salary { get; set; }
        public bool PayStatus { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string number, int salary)
        {
            Name = name;
            Number = number;            
        }

        public void PayEmployee()
        {
            PayStatus = false;
            Console.WriteLine("You've been paid for this week!");
            
        }

        public virtual void DrawBlood(Patient patient)
        {

        }

        public virtual void CarePatient(Patient patient)
        {

        }

        

    }
}
