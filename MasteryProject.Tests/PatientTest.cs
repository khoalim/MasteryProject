using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MasteryProject.Tests
{
    public class PatientTest
    {
        Patient patient;

        public PatientTest()
        {
            patient = new Patient();
        }

        [Fact]
        public void Doctor_Should_Decrease_BloodLevel_By_5()
        {
            patient.BloodLevel = 20;

            patient.DoctorDrawBlood();

            Assert.Equal(15, patient.BloodLevel);
        }

        [Fact]
        public void Nurse_Should_Increase_HealthLevel_By_2()
        {
            patient.HealthLevel = 10;

            patient.NurseCarePatient();

            Assert.Equal(12, patient.HealthLevel);
        }
    }
}
