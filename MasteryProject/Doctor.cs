using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Doctor : Employee
    {
        public string Speciality { get; set; }

        public Doctor()
        {

        }


        public Doctor(string name, string number, int salary, string speciality) : base(name, number, salary, false)
        {
            Speciality = speciality;
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;
        }

        public override void CarePatient(Patient patient)
        {
            patient.HealthLevel += 5;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Doctor: {Name}, {Number}, ${Salary}, {Speciality}");

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
