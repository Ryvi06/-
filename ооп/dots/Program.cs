using System;
using System.Collections.Generic;

namespace dots
{
    internal class Program
    {
        static List<Dot> dots;
        static void Main(string[] args)
        {
            dots = new List<Dot>();
            while (true)
            {
                Console.WriteLine("1. создать точку 2. найти расстояние 3. выйти");
                string choice = Console.ReadLine();
                if(choice == "3")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        MakeDot();
                        break;
                    case "2":
                        Distance();
                        break;
                }
            }
        }
        static void MakeDot()
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());
            Dot dot = new Dot(x, y);
            dots.Add(dot);
        }

        static void Distance()
        {
            int index = 1;
            foreach(Dot dot in dots)
            {
                Console.WriteLine($"{index}. ({dot.X};{dot.Y})");
                index++;
            }
            Console.Write("Выберите первую точку: ");
            int fstDotIndex = int.Parse(Console.ReadLine());
            Console.Write("Выберите вторую точку: ");
            int scndDotIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(dots[fstDotIndex-1].FindDistance(dots[scndDotIndex-1]).ToString());
        }
    }

    internal class Dot
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Dot(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double FindDistance(Dot secondDot)
        {
            double resault = Math.Sqrt(Math.Pow(secondDot.X - this.X, 2) + Math.Pow(secondDot.Y - this.Y, 2));
            return Math.Round(resault, 4);
        }
    }
}
