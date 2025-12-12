using System;
using System.Globalization;

namespace SchoolSimulationOOP {
    static class Program {
        static bool GetUserAnswer()
        {
            string userAnswer = Console.ReadLine().ToLower();
            return userAnswer == "yes";
        }

        static bool CheckIndexInput(School school, string input)
        {
            foreach (char c in input)
                if (!char.IsDigit(c))
                    return false;

            int n = int.Parse(input);
            if (n > school.Students.Count || n < 1)
                return false;

            return true;
        }

        static bool CheckAgeInput(string input)
        {
            foreach (char c in input)
                if (!char.IsDigit(c))
                    return false;

            int n = int.Parse(input);
            if (n <= 0)
                return false;

            return true;
        }

        static void Main()
        {
            Console.WriteLine("Hello! Enter the name of your school");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"School {school.Name} has been successfully created");

            while (true)
            {
                Console.WriteLine($"Do you want to see the list of students at school {school.Name}? Enter yes or no.");
                bool isPositiveAnswer = GetUserAnswer();
                if (isPositiveAnswer)
                    school.PrintStudents();

                Console.WriteLine($"Do you want to add a new student to school {school.Name}? Enter yes or no.");
                isPositiveAnswer = GetUserAnswer();
                if (isPositiveAnswer)
                {
                    Console.WriteLine("Enter the student's first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter the student's last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter the student's age");
                    string ageInput = Console.ReadLine();

                    if (CheckAgeInput(ageInput))
                    {
                        int age = int.Parse(ageInput);
                        Student student = new Student(firstName, lastName, age);
                        school.AddNewStudent(student);
                    }
                    else
                    {
                        Console.WriteLine("Invalid age input");
                    }
                }

                Console.WriteLine($"Do you want to remove one of the students from school {school.Name}? Enter yes or no.");
                isPositiveAnswer = GetUserAnswer();
                if (isPositiveAnswer)
                {
                    Console.WriteLine("Enter the student number to remove");
                    string userAnswer = Console.ReadLine();
                    if (CheckIndexInput(school, userAnswer))
                        school.RemoveStudent(int.Parse(userAnswer));
                    else
                        Console.WriteLine("Invalid input");
                }
            }
        }
    }
}