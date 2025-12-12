using System;
using System.Collections.Generic;

namespace SchoolSimulationOOP
{
    class School
    {
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
                Console.WriteLine($"В школе {Name} пока нет учеников!");
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
            Console.WriteLine($"Студент {student.FirstName} успешно добавлен в школу {Name}.");
        }

        public void GetRidOffStudent(int index)
        {
            index--;
            Console.WriteLine($"Студент {Students[index].FirstName} вас больше никогда не побеспокоит...");
            Students.RemoveAt(index);
        }
    }
}
