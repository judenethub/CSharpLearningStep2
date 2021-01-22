using System;

namespace Learning
{
    class Program
    {
       class Invoice
        {
            readonly int account; readonly string customer, provider;
            private string article; private int quantity;
            public int P
            {
                set { quantity = value; }
            }

            public Invoice(int account, string customer, string provider)
            {
                this.account = account;
                this.customer = customer;
                this.provider = provider;
            }
            //double sum = 0;
            public void Shop()
            {
                 double sum = 5000 * quantity;
                
                Console.WriteLine($"Уважаемый {customer} \nСчет-фактура номер {account} от {provider}:\nСумма без НДС равна {sum}, с НДС - {sum * 1.2}");
            }
        }



        static void Main()
        {
            Invoice abc = new Invoice(1, "Крузенштерн", "ВашПоставщик");
            Console.WriteLine($"Сколько товара купить хотите ?");
            abc.P = Convert.ToInt32(Console.ReadLine());
            abc.Shop();


            Console.ReadKey();
        }
    }
}

