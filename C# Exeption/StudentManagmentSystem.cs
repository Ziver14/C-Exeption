using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exeption
{
    public class StudentManagmentSystem
    {
        public List<Student> students = new List<Student>();

        public void AddStudent(string name, int age)
        {
           students.Add(new Student { Name = name, Age = age });
        }

        public void RemoveStudent(string name)
        {
           foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    student.Remove(student);
                }
            }

        }
        public void GetStudentByName(string name)
        {
           var student = students.FirstOrDefault(x => x.Name == name);
            if (student != null)
            {
                students.Remove(student);
            }
        }
        public void Print()
        {
            foreach (Student student in students)
            {
               Console.WriteLine($"{student.Name},{student.Age}");
            }
        }

    }
}
