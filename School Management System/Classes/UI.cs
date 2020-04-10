using System;

namespace School_Management_System.Classes
{
    class UI
    {
        public string GetName()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            return name;
        }

        public string GetFatherName()
        {
            Console.Write("Enter your Father's Name: ");
            string fatherName = Console.ReadLine();
            return fatherName;
        }

        public string GetAddress()
        {
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();
            return address;
        }

        public string GetID()
        {
            Console.Write("Enter your ID: ");
            string id = Console.ReadLine();
            return id;
        }
    }
}
