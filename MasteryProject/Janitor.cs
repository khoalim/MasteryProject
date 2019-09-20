using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Janitor : Employee
    {
        bool SweepingStatus { get; set; }


        public Janitor(string name, string number, int salary, bool SweepingStatus) : base(name, number, salary, false)
        {
            SweepingStatus = false;
        }

        public override void DrawBlood(Patient patient)
        {
            Console.WriteLine("This employee is not authorized to work on patients!");
        }

        public override void CarePatient(Patient patient)
        {
            Console.WriteLine("This employee is not authorized to work on patients!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Janitor:{Name}, {Number}, ${Salary}, {SweepingStatus}");
        }

        public void CheckSweepingStatus()
        {
            if (SweepingStatus == false)
            {
                Console.WriteLine("Not Sweeping");
            }
            else if (SweepingStatus == true)
            {
                Console.WriteLine("Sweeping");
            }
        }

            public override void PayEmployee()
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
    }
}
