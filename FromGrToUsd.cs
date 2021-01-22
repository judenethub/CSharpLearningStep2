using System;

namespace Learning
{
    class Program
    {
        class Converter
        {
            public double usd, eur, rub;
            public Converter(double eur, double usd, double rub)
            {
                this.eur = eur;
                this.usd = usd;
                this.rub = rub;
            }

            public void GrToEuroUsdRub(double gr)
            {
                
                Console.WriteLine("В какую валюту? Нажмите 1 если в евро, 2 в доллары, 3 в рубли  - ");
                string sw = Console.ReadLine();
                double res = 0;
                switch (sw)
                {
                    case "1":
                        res = gr * this.eur;
                        break;
                    case "2":
                        res = gr * this.usd;
                        break;
                    case "3":
                        res = gr * this.rub;
                        break;
                }

                Console.WriteLine("{0:F}", res);
            }
            public void FromEuroUsdRubToGr(double gr2, string sd)
            {
                
                double res2 = 0;
                switch (sd)
                {
                    case "1":
                        res2 = gr2 / this.eur;
                        break;
                    case "2":
                        res2 = gr2 / this.usd;
                        break;
                    case "3":
                        res2 = gr2 / this.rub;
                        break;
                }
                Console.WriteLine(res2);
            }

        }

        static void Main()
        {
            Converter abc = new Converter(0.03, 0.05, 0.07);
            
            Console.WriteLine("Сколько гривен перевести?");
            double gr = Convert.ToDouble(Console.ReadLine());
            abc.GrToEuroUsdRub(gr);

            Console.WriteLine("Из какой валюты в гривну? Нажмите 1 если из евро, 2 из долларов, 3 из рублей ");
            string sd = Console.ReadLine();
            Console.WriteLine("Сколько монет");
            double gr2 = Convert.ToDouble(Console.ReadLine());
            abc.FromEuroUsdRubToGr(gr2,sd);
            Console.ReadKey();

        }
    }
}

