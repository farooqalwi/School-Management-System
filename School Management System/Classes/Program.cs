using System;
using School_Management_System.Classes;

namespace School_Management_System
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to ABC School");
            Console.WriteLine("_____________________");

            // An object of UIController Class to call its functions.
            UIController uiController = new UIController();

            string id;
            string choice;
            bool exit = false;

            do
            {
                Console.WriteLine("\n1. To add a student press 1");
                Console.WriteLine("2. To view a student press 2");
                Console.WriteLine("3. To delete a student press 3");
                Console.WriteLine("4. To edit details press 4");
                Console.WriteLine("5. To search student press 5");
                Console.WriteLine("6. To exit menu press 6");

                Console.Write("Choose an appropriate option: ");
                choice = Console.ReadLine();
                Console.WriteLine("\n*************************\n");

                switch (choice)
                {
                    case "1":
                        uiController.GetData();
                        break;
                    case "2":
                        uiController.ViewStudentList();
                        break;
                    case "3":
                        uiController.DeleteStudent();
                        break;
                    case "4":
                        uiController.EditStudent();
                        break;
                    case "5":
                        uiController.SearchStudent();
                        break;
                    case "6":
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
