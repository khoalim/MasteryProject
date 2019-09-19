using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Employee
    {
        string Name { get; set; }
        string Number { get; set; }
        int Salary { get; set; }
        bool PayStatus { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string number, int salary, bool paystatus)
        {
            Name = name;
            Number = number;
            Salary = salary;
            PayStatus = paystatus;
        }

        public virtual void AddEmployee (string name, string number, int salary, bool paystatus)
        {
            Name = name;
            Number = number;
            Salary = salary;
            PayStatus = paystatus;
        }

     public void PayEmployee()
        {
            PayStatus = true;
            Console.WriteLine("You've been paid for this week!");
            
        }
    }
}
