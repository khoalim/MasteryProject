using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Employee
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int Salary { get; set; }
        public int Paid { get; set; }


        public Employee()
        {
            Paid = 0;
        }

        public Employee(string name, string number, int salary)
        {
            Name = name;
            Number = number;
            Salary = salary;
            
        }              

        public virtual void DrawBlood(Patient patient)
        {

        }

        public virtual void CarePatient(Patient patient)
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name}, {Number}, {Salary}");
        }
        
        public void PayEmployee()
        {

            Console.Clear();
            Paid++;
            if (Paid <=1)
            {
                Console.WriteLine("Employees have not been Paid");
                Console.WriteLine("\nTo pay Employees press 'P'");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }

            else if (Paid == 2)
            {
                Console.WriteLine("You have Paid your Employees");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }
            else if (Paid >= 3)
            {
                Console.WriteLine("You have already Paid your employees");
                Console.WriteLine("\nPress 'M' to return to Main Menu");
            }

        }

            
        } 
                        
        }
    

