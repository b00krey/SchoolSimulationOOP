using System;
using System.Collections.Generic;

namespace SchoolSimulationOOP {
    class School {
        public string Name;
        public List<Student> Students;
        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void PrintStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"There are no students in school {Name} yet!");
            }
            else
            {
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("{0}. {1, -15} {2, -15} {3, -15}", i + 1, Students[i].FirstName, Students[i].LastName, Students[i].Age);
                }
            }
        }

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"Student {student.FirstName} has been successfully added to school {Name}.");
        }

        public void RemoveStudent(int index)
        {
            index--;
            Console.WriteLine($"Student {Students[index].FirstName} will never bother you again...");
            Students.RemoveAt(index);
        }
    }
}