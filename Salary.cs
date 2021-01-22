using System;

namespace Learning
{
    class Program
    {
       class Employer
        {
            string name, surname;
            public Employer(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }

            public void Salary()
            {
                string position = "Admin";
                double salary = 10000;
                double tax = salary * 0.05;
                Console.WriteLine($"Имя - {name},\nФамилия - {surname},\nДолжность - {position}, \nОклад - {salary}, \nналоговый сбор - {tax}");
            }
        }



        static void Main()
        {
            Employer abc = new Employer("Вася","Петин");
            abc.Salary();


            Console.ReadKey();
        }
    }
}

