using System.Collections.Generic;

namespace School_Management_System.Classes
{
    class StudentList
    {
        public List<Student> studentsList = new List<Student>();

        public bool AddStudent(string name, string fatherName, string address, string id)
        {
            Student student = new Student();
            student.Name = name;
            student.FatherName = fatherName;
            student.Address = address;
            student.ID = id;

            studentsList.Add(student);
            return true;
        }
    }
}
