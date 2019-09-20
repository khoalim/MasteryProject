using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Patient
    {        
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }
        public string Name { get; set; }

        public Patient()
        {

        }

        public Patient(string name, int bloodlevel, int healthlevel)
        {
            BloodLevel = 20;
            HealthLevel = 10;
            Name = name;
        }

         
        
       
    }
}
