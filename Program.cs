using System;

namespace AcademicProject
{
    // Оголошення класу Student відповідно до завдання
    class Student
    {
        // Поля класу для збереження імені та групи
        public string Name;
        public string Group;
        
        // Домашнє завдання: нове поле для збереження середнього балу
        public double AverageScore;

        // Метод для зручного виведення інформації про студента на екран
        public void DisplayInfo()
        {
            Console.WriteLine("Студент: " + Name);
            Console.WriteLine("Група: " + Group);
            Console.WriteLine("Середній бал: " + AverageScore);
            Console.WriteLine("-------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("    ПРАКТИЧНЕ ЗАНЯТТЯ №1: СТВОРЕННЯ КЛАСІВ І ОБ'ЄКТІВ    ");
            Console.WriteLine("=========================================================");
            Console.WriteLine();

            // Створення першого об'єкта класу Student
            Student student1 = new Student();
            student1.Name = "Цілик Інна";
            student1.Group = "П-34";
            student1.AverageScore = 4.8; // Середній бал (Домашнє завдання)

            // Створення drugogo об'єкта класу Student
            Student student2 = new Student();
            student2.Name = "Крейзер Євгенія";
            student2.Group = "17ОД";
            student2.AverageScore = 4.5; // Середній бал (Домашнє завдання)

            // Виведення інформації про об'єкти на екран
            Console.WriteLine("--- Інформація про згенеровані об'єкти списку ---");
            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.WriteLine("✅ Програму успішно виконано!");
        }
    }
}
