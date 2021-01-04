using System;


namespace ConsoleApp1
{
    class Program
    {
        
        class Rectangle
        {
            private double side1, side2;

           public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }

           public double AreaCalculator(double side1, double side2)
            {

                return side1* side2;
            }

            public double PerimeterCalculator(double side1, double side2)
            {
                return 2 * side1 + 2 * side2;
            }

            public double Area
            {
                get { return AreaCalculator(side1, side2); }
            }
            public double Perimeter
            {
                get { return PerimeterCalculator(side1, side2); }
            }

        }



        public static void Main(String[] args)
        {

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Rectangle abc = new Rectangle(x,y);
            Console.WriteLine($"Площадь равна {abc.Area}, периметр равен {abc.Perimeter}");





            Console.ReadKey();
        }
    }
}