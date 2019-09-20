using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Doctor : Employee
    {
        public string Speciality { get; set; }
        

       public Doctor(string name, string number, int salary, string speciality) : base(name, number, salary)
        {
            Speciality = Speciality;            
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;            
        }

        public override void CarePatient(Patient patient)
        {
            patient. HealthLevel += 5;            
        }
    }
}
