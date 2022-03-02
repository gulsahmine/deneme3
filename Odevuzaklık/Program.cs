using System;
using System.Collections.Generic;

namespace Odevuzaklik.Nokta
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokta p1 = new Nokta(2, 3);
            Nokta p2 = new Nokta(3, 4);
            Console.WriteLine(p1.UzaklikHesapla(p2));
        }
         

     }

    class Nokta
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Nokta(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double UzaklikHesapla(Nokta digernokta)
        {
            return Math.Sqrt(Math.Pow(digernokta.X-X,2) + Math.Pow(digernokta.Y-Y,2));
        }

    }








}
