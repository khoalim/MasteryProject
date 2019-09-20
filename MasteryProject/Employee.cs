using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Employee
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int Salary { get; set; }
        public bool PayStatus { get; set; }


        public Employee()
        {

        }

        public Employee(string name, string number, int salary, bool paystatus)
        {
            Name = name;
            Number = number;
            Salary = salary;
            PayStatus = false;
        }

        public virtual void PayEmployee()
        {
            if (PayStatus == false)
            {
                Console.WriteLine("Paid");
            }
            else if (PayStatus == !PayStatus)
            {
              Console.WriteLine("Not Paid");
            }                 
            
        }

        public virtual void DrawBlood(Patient patient)
        {

        }

        public virtual void CarePatient(Patient patient)
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name}, {Number}, {Salary}");
        }

        

    }
}
