using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace MasteryProject.Tests
{
    public class DoctorTests
    {
        Patient patient;

        public DoctorTests()
        {
            patient = new Patient();
        }

        [Fact]
        public void Doctor_Should_Decrease_BloodLevel_By_5()
        {
            Doctor doctor = new Doctor();
            patient.BloodLevel = 20;

            doctor.DrawBlood(patient);

            Assert.Equal(15, patient.BloodLevel);
        }

        [Fact]
        public void Doctor_Should_Increase_HealthLevel_By_5()
        {
            Doctor nurse = new Doctor();
            patient.HealthLevel = 10;

            nurse.CarePatient(patient);

            Assert.Equal(5, patient.HealthLevel);
        }
    }
}
