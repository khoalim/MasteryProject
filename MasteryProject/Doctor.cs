using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Doctor : Employee
    {
        string Speciality { get; set; }

        public override void AddEmployee(string name, string number, int salary, bool paystatus)
        {
            base.AddEmployee(name, number, speciality, salary, paystatus);
            Speciality = speciality;
        }

        
       


    }
}
