using System;

namespace School_Management_System
{
    class Student
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string ID { get; set; }

        public void Display()
        {
            Console.WriteLine("Name:\t\t" + Name);
            Console.WriteLine("Father's Name:\t" + FatherName);
            Console.WriteLine("Address:\t" + Address);
            Console.WriteLine("Student's ID:\t" + ID);
        }
    }
}
