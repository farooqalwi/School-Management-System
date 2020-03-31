using System;

namespace School_Management_System
{
    class Student
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }

        public static void AddStudent()
        {
            Student student = new Student();
            Console.Write("Student's Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Father's Name: ");
            student.FatherName = Console.ReadLine();
            Console.Write("Address: ");
            student.Address = Console.ReadLine();
            Console.WriteLine("Student added.");
        }

        public static void ViewStudent()
        {
            Console.WriteLine("Name: ");
            Console.WriteLine("Father's Name: ");
            Console.WriteLine("Address: ");
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
