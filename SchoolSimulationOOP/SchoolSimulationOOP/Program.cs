using System;

namespace SchoolSimulationOOP
{
    static class Programm
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Введите название вашей школы");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешно создана");

            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список учеников школы {school.Name}? Введите да или нет. ");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "да")
                    school.PrintStudents();

                Console.WriteLine($"Хотите добавить нового ученика в школу {school.Name}? Введите да или нет. ");
                userAnswer = Console.ReadLine();
                if (userAnswer == "да")
                {
                    Console.WriteLine("Введите имя ученика");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию ученика");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Введите возраст ученика");
                    int age = int.Parse(Console.ReadLine());

                    Student student = new Student(firstName, lastName, age);
                    school.AddNewStudent(student);
                }
            }
        }
    }
}