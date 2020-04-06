using System;
using System.Collections.Generic;

namespace School_Management_System
{
    class StudentController
    {
        private List<Student> studentsList = new List<Student>();
        private string name, fatherName, address, id, option;

        public void AddStudent()
        {
            Console.Write("Student's Name:\t");
            name = Console.ReadLine();
            Console.Write("Father's Name:\t");
            fatherName = Console.ReadLine();
            Console.Write("Address:\t");
            address = Console.ReadLine();
            Console.Write("Student's ID:\t");

            option = "addStudent";
            checkID();
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
                    break;
                }
            }
            return matchFound;
        }

        public void Delete(string id)
        {
            int ind = -1;

            foreach (Student obj in studentsList)
            {
                if (id == obj.ID)
                {
                    ind = studentsList.IndexOf(obj);
                    break;
                }
            }

            if (ind >= 0)
            {
                studentsList.RemoveAt(ind);
                Console.WriteLine("Student Deleted.");
            }
            else
            {
                Console.WriteLine("ID not found.");
            }
        }

        public void Edit(string id)
        {
            option = "edit";
            checkID();
        }

        private void checkID()
        {
            bool isIDInvalid = true;
            
            do
            {
                id = Console.ReadLine();

                if (id != "")
                {
                    switch (option)
                    {
                        case "addStudent":
                            if (!isStudentIDUnique(id))
                            {
                                Student student = new Student();
                                student.Name = name;
                                student.FatherName = fatherName;
                                student.Address = address;
                                student.ID = id;

                                studentsList.Add(student);
                                Console.WriteLine("\nStudent added.");

                                isIDInvalid = false;
                            }
                            else
                            {
                                Console.WriteLine("This ID is already used.");
                                Console.Write("Please Enter a valid ID: ");
                            }
                            break;
                        case "edit":
                            if (isStudentIDUnique(id))
                            {
                                foreach (Student obj in studentsList)
                                {
                                    Console.WriteLine("Old Details");
                                    obj.Display();

                                    Console.Write("Enter new Name: ");
                                    obj.Name = Console.ReadLine();
                                    Console.Write("Enter Father's Name: ");
                                    obj.FatherName = Console.ReadLine();
                                    Console.Write("Enter new Address: ");
                                    obj.Address = Console.ReadLine();
                                    Console.WriteLine("Details edited.");
                                    break;
                                }
                                isIDInvalid = false;
                            }
                            else
                            {
                                Console.WriteLine("ID not found.");
                                Console.Write("Enter an existing ID.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ID cannot be empty.");
                    Console.Write("Please Enter a valid ID: ");
                }
            } while (isIDInvalid);
            
        }
    }
}
