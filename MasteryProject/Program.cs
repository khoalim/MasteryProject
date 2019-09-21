using System;
using System.Collections.Generic;

namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();
            Employee employee = new Employee();            
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            Patient patient = new Patient();
            hospital.AddEmployees();
            hospital.AddPatients();
            hospital.MainMenu();

            bool inHospitalMenu = true;
            
            while (inHospitalMenu)
            {
               
                string userInput= Console.ReadLine().ToLower();


                switch (userInput)
                {                    
                    case "a":
                        Console.Clear();
                        Console.WriteLine("The hospital employees are:");
                        Console.WriteLine(); //<-- Here to add some space btwn heading and list
                        hospital.ShowAllEmployees();
                        hospital.TasksOnEmployees();                        
                        break;                               

                    case "r":
                        receptionist.CheckPhoneStatus();
                        break;

                    case "j":
                        janitor.CheckSweepingStatus();
                        break;

                    case "p":
                        employee.PayEmployee();
                        break;

                    case "m":
                        Console.Clear();
                        hospital.MainMenu();
                        break;


                    case "b":
                        Console.Clear();
                        Console.WriteLine("The hospital patients are:");
                        Console.WriteLine(); //<-- Here to add some space btwn heading and list
                        hospital.ShowAllPatients();
                        hospital.TasksOnPatients();
                        break;

                    case "db":
                        Console.Clear();
                        hospital.ShowAllPatients();
                        hospital.DoctorDrawBloodforIndividualPatient();
                        Console.WriteLine("Your patients' new stats are:");
                        hospital.ShowAllPatients();
                        patient.ReturnToPatientList();
                        break;
                        

                    case "dc":
                        Console.Clear();
                        hospital.ShowAllPatients();
                        hospital.DoctorCareforIndividualPatient();
                        Console.WriteLine("Your patients' new stats are:");
                        hospital.ShowAllPatients();
                        patient.ReturnToPatientList();
                        break;

                    case "nb":
                        Console.Clear();
                        hospital.ShowAllPatients();
                        hospital.NurseDrawBloodforIndividualPatient();
                        Console.WriteLine("Your patients' new stats are:");
                        hospital.ShowAllPatients();
                        patient.ReturnToPatientList();
                        break;
                       

                    case "nc":
                        Console.Clear();
                        hospital.ShowAllPatients();
                        hospital.NurseCareforIndividualPatient();
                        Console.WriteLine("Your patients' new stats are:");
                        hospital.ShowAllPatients();
                        patient.ReturnToPatientList();
                        break;
                                            

                    case "c":
                        inHospitalMenu = false;
                        Console.WriteLine("GoodBye! Thanks for Visiting!");
                        break;
                                               
                    default:
                        Console.WriteLine("Invalid Entry. Please Try Again!");
                        break;
                }

            }           
                                             
        }
        
    }
}
