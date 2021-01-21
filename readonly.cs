using System;

namespace Learning
{
    class Program
    {
        class User
        {
            public string login = "judenet", name = "vasya", surname = "Smirnov", age ="40"; 
            public readonly string date;

            public User()
            {
                date = "19.08.1979";
            }

           

            
        }
        static void Main()
        {
            User abc = new User();
            Console.WriteLine($"Возраст - {abc.age}, логин - {abc.login}, Имя - {abc.name}, Фамилия - {abc.surname}, дата - {abc.date}. ");
            

            Console.ReadKey();
        }
    }
}

