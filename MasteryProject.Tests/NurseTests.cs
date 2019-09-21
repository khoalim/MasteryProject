using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MasteryProject.Tests
{
    public class NurseTests
    {
        Patient patient;

        public NurseTests()
        {
            patient = new Patient();
        }

        [Fact]
        public void Nurse_Should_Decrease_BloodLevel_By_2()
        {
            Nurse nurse = new Nurse();
            patient.BloodLevel = 20;

            nurse.DrawBlood(patient);

            Assert.Equal(18, patient.BloodLevel);
        }

        [Fact]
        public void Nurse_Should_Increase_HealthLevel_By_2()
        {
            Nurse nurse = new Nurse();
            patient.HealthLevel = 10;

            nurse.CarePatient(patient);

            Assert.Equal(8, patient.HealthLevel);
        }
    }
}

