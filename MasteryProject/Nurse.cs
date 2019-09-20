using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }

        public Nurse()
        {

        }


        public Nurse(string name, string number, int salary, int numberofPatients) : base(name, number, salary, false)
        {
            NumberofPatients = numberofPatients;
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 2;
        }

        public override void CarePatient(Patient patient)
        {
            patient.HealthLevel += 2;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Nurse:{Name}, {Number}, ${Salary}, {NumberofPatients} patients");
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
