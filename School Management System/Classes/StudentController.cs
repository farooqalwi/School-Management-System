using System;
using System.Collections.Generic;

namespace School_Management_System
{
    class StudentController
    {
        private List<Student> studentsList = new List<Student>();

        public void AddStudent()
        {
            string name, fatherName, address;

            Console.Write("Student's Name:\t");
            name = Console.ReadLine();
            Console.Write("Father's Name:\t");
            fatherName = Console.ReadLine();
            Console.Write("Address:\t");
            address = Console.ReadLine();

            var id = getStudentID(true);

            Student student = new Student();
            student.Name = name;
            student.FatherName = fatherName;
            student.Address = address;
            student.ID = id;

            studentsList.Add(student);
            Console.WriteLine("Student added with ID {0}", id);
        }

        public void ViewStudentList()
        {
            foreach (Student student in studentsList)
            {
                student.Display();
            }

            Console.WriteLine("\nStudent List viewed.");
        }

        public void DeleteStudent()
        {
            if (studentsList.Count == 0)
            {
                Console.WriteLine("You must first enter students");
            }
            else
            {
                Console.WriteLine("You must enter an exisiting Student ID");
                var id = getStudentID(false);

                int index = -1;

                foreach (Student obj in studentsList)
                {
                    if (id == obj.ID)
                    {
                        index = studentsList.IndexOf(obj);
                        // No need to continue the forEach loop
                        break;
                    }
                }

                studentsList.RemoveAt(index);
                Console.WriteLine("Student Deleted with ID {0}", id);
            }
        }

        public void EditStudent()
        {
            if (studentsList.Count == 0)
            {
                Console.WriteLine("You must first enter students");
            }
            else
            {
                Console.WriteLine("You must enter an exisiting Student ID");
                var id = getStudentID(false);

                foreach (Student obj in studentsList)
                {
                    if (id == obj.ID)
                    {
                        Console.WriteLine("Old Details.");
                        obj.Display();

                        Console.Write("Enter new Name: ");
                        obj.Name = Console.ReadLine();
                        Console.Write("Enter Father's Name: ");
                        obj.FatherName = Console.ReadLine();
                        Console.Write("Enter new Address: ");
                        obj.Address = Console.ReadLine();
                        // No need to continue the forEach loop
                        break;
                    }
                }

                Console.WriteLine("Student's details edited with ID {0}", id);
            }
        }

        private string getStudentID(bool getNewID)
        {
            string id = "";
            bool isIDValid = false;

            do
            {
                Console.Write("Student's ID:\t");
                id = Console.ReadLine();

                if (id == "")
                {
                    Console.WriteLine("Student ID cannot be empty");
                }
                else
                {
                    if (studentsList.Count == 0)
                    {
                        isIDValid = getNewID;
                    }

                    // Now we need to make sure 
                    // either the ID is unique
                    // or the ID is present
                    foreach (Student obj in studentsList)
                    {
                        // We need new student ID
                        // Make sure ID has not been used
                        if (getNewID)
                        {
                            if (obj.ID == id)
                            {
                                Console.WriteLine("Student ID already in use. Try again");
                                isIDValid = false;
                                // No need to continue the forEach loop 
                                break;
                            }
                            else
                            {
                                isIDValid = true;
                            }
                        }
                        else
                        {
                            // Make sure ID is present                  
                            if (obj.ID == id)
                            {
                                isIDValid = true;
                                // No need to continue the forEach loop 
                                break;
                            }
                        }
                    }

                    // Print error message
                    if (isIDValid == false && getNewID == false)
                    {
                        Console.WriteLine("Student ID {0} is not present. Try again", id);
                    }
                }
            } while (!isIDValid);

            return id;
        }

        public void SearchStudent()
        {
            Console.WriteLine("-If you want to search student by name then press 1");
            Console.WriteLine("-If you want to search student by fatherName then press 2");
            Console.WriteLine("-If you want to search student by address then press 3");

            Console.Write("Choose an appropriate option: ");
            string option = Console.ReadLine();

            if (studentsList.Count == 0)
            {
                Console.WriteLine("You must first enter students");
            }
            else
            {
                switch (option)
                {
                    case "1":
                        Console.Write("Enter student's name: ");
                        string name = Console.ReadLine();
                        foreach (Student obj in studentsList)
                        {
                            if (name == obj.Name)
                            {
                                obj.Display();
                                Console.WriteLine("Your search is given.");
                                break;
                            }
                        }
                        break;
                    case "2":
                        Console.Write("Enter father's name: ");
                        string fatherName = Console.ReadLine();
                        foreach (Student obj in studentsList)
                        {
                            if (fatherName == obj.FatherName)
                            {
                                obj.Display();
                                Console.WriteLine("Your search is given.");
                                break;
                            }
                        }
                        break;
                    case "3":
                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();
                        foreach (Student obj in studentsList)
                        {
                            if (address == obj.Address)
                            {
                                obj.Display();
                                Console.WriteLine("Your search is given.");
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
