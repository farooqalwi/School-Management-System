using System;
using System.Collections.Generic;

namespace School_Management_System
{
    class StudentController
    {
        private List<Student> studentsList = new List<Student>();

        public void AddStudent()
        {
            string name, fatherName, address, id;

            Console.Write("Student's Name:\t");
            name = Console.ReadLine();
            Console.Write("Father's Name:\t");
            fatherName = Console.ReadLine();
            Console.Write("Address:\t");
            address = Console.ReadLine();
            Console.Write("Student's ID:\t");
            id = Console.ReadLine();

            if (id != "")
            {
                Student student = new Student();
                student.Name = name;
                student.FatherName = fatherName;
                student.Address = address;
                student.ID = id;

                if (isStudentIDUnique(id))
                {
                    Console.WriteLine("This ID already has been used.");
                }

                else
                {
                    studentsList.Add(student);
                    Console.WriteLine("\nStudent added.");
                }

            }
            else
            {
                Console.WriteLine("Please Enter Student's ID.");
            }
        }

        public void View()
        {
            foreach (Student student in studentsList)
            {
                student.Display();
            }
            Console.WriteLine("\nStudent List viewed.");
        }

        private bool isStudentIDUnique(string id)
        {
            bool matchFound = false;

            foreach (Student obj in studentsList)
            {
                if (id == obj.ID)
                {
                    matchFound = true;
                }
            }
            return matchFound;
        }
    }
}
