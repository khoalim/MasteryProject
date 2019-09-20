using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Hospital

    {
       public List<Employee> hospitalEmployees = new List<Employee>();

       public List<Patient> hospitalPatients = new List<Patient>();

        public void AddEmployees()
        {
            hospitalEmployees.Add(new Doctor("Doogie Howser", "D101", 90000, "Pediatrics"));
            hospitalEmployees.Add(new Doctor("Gregory House", "D102", 90000, "Diagnostics"));
            hospitalEmployees.Add(new Doctor("Miranda Bailey", "D103", 90000, "Surgery"));

            hospitalEmployees.Add(new Nurse("Carla Espinosa", "N201", 50000, 4));
            hospitalEmployees.Add(new Nurse("Carol Hathaway", "N202", 50000, 2));
            hospitalEmployees.Add(new Nurse("Christina Hawthorn", "N203", 50000, 3));

            hospitalEmployees.Add(new Receptionist("Peggy Olson", "R301", 45000));
            hospitalEmployees.Add(new Receptionist("Pam Beesly", "R302", 45000));

            hospitalEmployees.Add(new Janitor("Groundskeeper Willie", "J401", 40000));
            hospitalEmployees.Add(new Janitor("Will Hunting", "J402", 40000));            
        }

        public void AddPatients()
        {
            hospitalPatients.Add(new Patient("Jane Doe", 20, 10));
            hospitalPatients.Add(new Patient("John Smith", 20, 10));
        }

        public void ShowAllEmployees()
        {
            int e = 1;
            foreach (Employee employee in hospitalEmployees)
            {
                Console.WriteLine($"{e}.{employee.Name}, {employee.Number}, {employee.Salary}");
                e++;
            }
        }

        public void ShowAllPatients()
        {
            int e = 1;
            foreach (Patient patient in hospitalPatients)
            {                
                Console.WriteLine($"{e}.{patient.Name}, {patient.BloodLevel}, {patient.HealthLevel}");
                e++;
            }
        }
        
    

    }  
           
    

    
}
