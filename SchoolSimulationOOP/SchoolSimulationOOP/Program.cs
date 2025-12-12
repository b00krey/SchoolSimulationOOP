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
            }
        }
    }
}