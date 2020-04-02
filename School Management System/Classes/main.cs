using System;

namespace School_Management_System
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to ABC School");
            Console.WriteLine("_____________________");

            // An object of StudentController Class to call its methods.
            StudentController studentController = new StudentController();

            string choice;
            bool exit = false;

            do
            {
                Console.WriteLine("\n1. To add a student press 1 \n2. To view a student press 2\n3. To delete a student press 3\n4. To exit menu press 4\n");
                Console.Write("Choose an appropriate option: ");
                choice = Console.ReadLine();
                Console.WriteLine("\n*************************\n");

                switch (choice)
                {
                    case "1":
                        studentController.AddStudent();
                        break;
                    case "2":
                        studentController.View();
                        break;
                    case "3":
                        Console.WriteLine("Student deleted.");
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Application ended.");
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("\n*************************");
            } while (!exit);
        }
    }
}
