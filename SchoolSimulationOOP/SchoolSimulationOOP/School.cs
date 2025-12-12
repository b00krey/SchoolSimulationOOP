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
                    Console.WriteLine("{0, -10} {1, -10}", Students[i].FirstName, Students[i].LastName);
                }
            }
        }
    }
}
