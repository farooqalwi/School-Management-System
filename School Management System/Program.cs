using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class Student
    {
        public static string Name { get; set; }
        public static string FatherName { get; set; }
        public static string Address { get; set; }

        public static void AddStudent()
        {

            Console.Write("Student's Name: ");
            Student.Name = Console.ReadLine();
            Console.Write("Father's Name: ");
            Student.FatherName = Console.ReadLine();
            Console.Write("Address: ");
            Student.Address = Console.ReadLine();
            Console.WriteLine("Student added.");
        }

        public static void ViewStudent()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Father's Name: " + FatherName);
            Console.WriteLine("Address: " + Address);

        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Add a student\t2. View a student\t3. Delete a student\t'exit' to close menu");

            string choice;
            bool exit = false;

            do
            {
                Console.Write("Choose an appropriate option:");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Student.AddStudent();
                        break;
                    case "2":
                        Student.ViewStudent();
                        break;
                    case "3":
                        Console.WriteLine("Student deleted.");
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            } while (!exit);
        }
    }
}
