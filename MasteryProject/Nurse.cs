using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }
        

        public Nurse(string name, string number, int salary, int numberofPatients) : base(name, number, salary)
        {
           NumberofPatients = numberofPatients;           
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;
        }

        public override void CarePatient(Patient patient)
        {
            patient.HealthLevel += 5;
        }
    }
}
