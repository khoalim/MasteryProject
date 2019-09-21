using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Hospital

    {
        Nurse nurse = new Nurse();
        Doctor doctor = new Doctor();

        public void MainMenu()
        {
            Console.WriteLine("Welcome to University Clinic Hospital!");
            Console.WriteLine("**************************************");

            Console.WriteLine("MAIN MENU:");
            Console.WriteLine("\nPress 'A' for list of Hospital employees");
            Console.WriteLine("\nPress 'B' for list of Hospital patients");
            Console.WriteLine("\nPress 'C' to Exit Hospital");
        }

        //For Employees
        public List<Employee> hospitalEmployees = new List<Employee>();


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
        
        public void ShowAllEmployees()
        {
            int e = 1;
            foreach (Employee employee in hospitalEmployees)
            {
                Console.Write($"{e}.");
                employee.ShowInfo();
                e++;
            }
        }            

        public void TasksOnEmployees()
        {
            Console.WriteLine("\nPress 'R' to view Receptionists' Status");
            Console.WriteLine("Press 'J' to view Janitors' Status");
            Console.WriteLine("Press 'P' to view Payroll Status");
            Console.WriteLine("\nPress 'M' to return to Main Menu");
        }
        
        //For Patients
        public List<Patient> hospitalPatients = new List<Patient>();

        public void ShowAllPatients()
        {
            int e = 1;
            foreach (Patient patient in hospitalPatients)
            {                
                Console.WriteLine($"{e}.{patient.Name}, Blood Level:{patient.BloodLevel}, Health Level:{patient.HealthLevel}");
                e++;
            }
        }
        public void AddPatients()
        {
            hospitalPatients.Add(new Patient("Jane Doe", 20, 10));
            hospitalPatients.Add(new Patient("John Smith", 20, 10));
        }

        public void TasksOnPatients()
        {
            Console.WriteLine("\nPress 'DB' for Doctor to draw patients' blood");
            Console.WriteLine("Press 'DC' for Doctor to care for patients");
            Console.WriteLine("Press 'NB' for Nurse to draw patients' blood");
            Console.WriteLine("Press 'NC' for Nurse to care for patients");
            Console.WriteLine("\nPress 'M' to return to Main Menu");
        }

        public void DoctorDrawBloodforIndividualPatient()
        {
            Console.WriteLine("\nPlease select a Patient");
            Patient patients = hospitalPatients[Convert.ToInt32(Console.ReadLine()) - 1];
            doctor.DrawBlood(patients);
            Console.Clear();
        }

        public void DoctorCareforIndividualPatient()
        {
            Console.WriteLine("\nPlease select a Patient");
            Patient patients = hospitalPatients[Convert.ToInt32(Console.ReadLine()) - 1];
            doctor.CarePatient(patients);
            Console.Clear();
        }

        public void NurseDrawBloodforIndividualPatient()
        {
            Console.WriteLine("\nPlease select a Patient");
            Patient patients = hospitalPatients[Convert.ToInt32(Console.ReadLine()) - 1];
            nurse.DrawBlood(patients);
            Console.Clear();
        }

        public void NurseCareforIndividualPatient()
        {            
            Console.WriteLine("\nPlease select a Patient");           
            Patient patients = hospitalPatients[Convert.ToInt32(Console.ReadLine()) - 1];
            nurse.CarePatient(patients);
            Console.Clear();
        }       
        
        

        

    }

} 

    
       
    

    

