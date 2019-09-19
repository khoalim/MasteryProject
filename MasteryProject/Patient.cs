using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Patient
    {
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }

        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }

        public void DoctorDrawBlood()
        {
            BloodLevel -= 5;            
        }

        public void NurseDrawBlood()
        {
            BloodLevel -= 2;            
        }

        public void DoctorCarePatient()
        {
            HealthLevel += 5;
        }

        public void NurseCarePatient()
        {
            HealthLevel += 2;
        }
    }
}
