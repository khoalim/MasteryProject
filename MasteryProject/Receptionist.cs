using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    class Receptionist : Employee
    {
        public bool PhoneStatus { get; set; }
        public int Phone { get; set; }

        public Receptionist(string name, string number, int salary) : base(name, number, salary)
        {

        }

        public Receptionist()
        {
            Phone = 0;
        }

        //public override void DrawBlood(Patient patient)
        //{
        //    Console.WriteLine("This employee is not authorized to work on patients!");
        //}

        //public override void CarePatient(Patient patient)
        //{

        //    Console.WriteLine("This employee is not authorized to work on patients!");
        //}

        public override void ShowInfo()
        {
            Console.WriteLine($"Receptionist: {Name}, {Number}, ${Salary}");
        }
        
        public void CheckPhoneStatus()
        {
            Console.Clear();
            Phone++;
            if (Phone % 2 == 1)
            {
                Console.WriteLine("All receptionists are on the phone");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }

            if (Phone % 2 == 0)
            {
                Console.WriteLine("All receptionists are available");
                Console.WriteLine("\nTo make receptionists answer the phone press 'R'");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }

        }

    }
}

