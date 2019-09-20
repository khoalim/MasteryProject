using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    class Receptionist : Employee
    {
        public bool PhoneStatus { get; set; }

              

        public Receptionist (string name, string number, int salary, bool phonestatus) : base(name, number, salary, false)
        {
            PhoneStatus = false;            
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
            Console.WriteLine($"Receptionist:{Name}, {Number}, ${Salary}, {PhoneStatus}");
        }

        public void CheckPhoneStatus()
        {
            if (PhoneStatus == false)
            {
                Console.WriteLine("Off Phone");
            }
            else if (PhoneStatus == true)
            {
                Console.WriteLine("On Call");
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
