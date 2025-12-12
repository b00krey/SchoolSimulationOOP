using System;
using System.Globalization;

namespace SchoolSimulationOOP
{
    static class Programm
    {
        static bool GetUSerAnswer()
        {
            string userAnswer = Console.ReadLine().ToLower();
            return userAnswer == "да";
        }

        static bool CheckIndexInput(School school, string input)
        {
            foreach (char c in input)
                if (!char.IsDigit(c))
                    return false;

            int n = int.Parse(input);
            if (n >= school.Students.Count || n < 0)
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
            Console.WriteLine("Здравствуйте! Введите название вашей школы");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешно создана");

            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список учеников школы {school.Name}? Введите да или нет. ");
                bool isPositiveAnswer = GetUSerAnswer();
                if (isPositiveAnswer)
                    school.PrintStudents();

                Console.WriteLine($"Хотите добавить нового ученика в школу {school.Name}? Введите да или нет. ");
                isPositiveAnswer = GetUSerAnswer();
                if (isPositiveAnswer)
                {
                    Console.WriteLine("Введите имя ученика");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию ученика");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Введите возраст ученика");
                    string ageInput = Console.ReadLine();

                    if (CheckAgeInput(ageInput))
                    {
                        int age = int.Parse(ageInput);
                        Student student = new Student(firstName, lastName, age);
                        school.AddNewStudent(student);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод возраста");
                    }              
                }

                Console.WriteLine($"Хотите избавиться от одного из ученков школы {school.Name}? Введите да или нет.");
                isPositiveAnswer = GetUSerAnswer();
                if (isPositiveAnswer)
                {
                    Console.WriteLine("Введите номер ученика для избавления");
                    string userAnswer = Console.ReadLine();
                    if (CheckIndexInput(school, userAnswer))
                        school.GetRidOffStudent(int.Parse(userAnswer));
                    else
                        Console.WriteLine("Некорректный ввод");
                }
            }
        }
    }
}