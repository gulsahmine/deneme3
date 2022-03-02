/*
Şekil, Kare ve Daire sınıfları yazılacak
Kare ve Daire, Sekil sınıfından türeyecek

Kare, bir kenar uzunluğu ile oluşturulacak
Daire, yariçap uzunluğu ile oluşturulacak

Sekil sınıfında, herhangi iki şekli birleştirebilen bir metot tanımlanacak.
Birleştirme işlemi, birleştirilen şekillerin alanlarının toplamının hesaplanması demek.

Aşağıdaki "Main" metotta kullanım şekli gösterilmiştir.
"Main" içine herhangi bir kod eklemesi yapılmayacak.
"Birlestir" metotu Sekil sınıfı üzerinden gerçekleştirilecek.

Bu çalışmayı sağlayan sınıfları yazınız.

Not: tüm işlemleri int tipinde yapınız. Pi sayısını 3 olarak kullanınız.
 */

using System;
using System.Collections.Generic;


namespace calisma14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            int birlesmisAlan;

            var d = new Daire(3);       // yarıçap 3 alan 27
            var k = new Kare(5);        // kenar 5 alan 25
            

            birlesmisAlan = Sekil.Birlestir(d, k);
            Console.WriteLine(birlesmisAlan);       // çıkış : 52

           // birlesmisAlan = Sekil.Birlestir(d, d);
            //Console.WriteLine(birlesmisAlan);       // çıkış : 54

            //birlesmisAlan = Sekil.Birlestir(k, k);
            //Console.WriteLine(birlesmisAlan);       // çıkış : 50
            
        }
    }

 interface IAlanHesaplanir
    {
        int AlanHesapla();
    }

    interface IDondurulebilir
    {
        void Dondur();
    }


}


      // abstract class Sekil
    // {
    //     public static int Birlestir(Sekil a, Sekil b)
    //     {
    //         return a.AlanHesapla() + b.AlanHesapla();
    //     }
    //     public abstract int AlanHesapla();
    // }

    // class Kare : Sekil
    // {
    //     private int _k;
    //     public Kare(int k)
    //     {
    //         _k = k;
    //     }

    //     public override int AlanHesapla()
    //     {
    //         return _k * _k;
    //     }

    // }

    // class Daire : Sekil
    // {
    //     private int _yc;
    //     public Daire(int yc)
    //     {
    //         _yc = yc;
    //     }

    //     public override int AlanHesapla()
    //     {
    //         return _yc * _yc * 3;
    //     }
    // }

















// namespace Calisma12.Nokta
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//         }
//     }

//     // class Nokta
//     // {
//     //     public double X { get; set; }
//     //     public double Y { get; set; }

//     //     public Nokta(double x, double y)
//     //     {
//     //         X = x;
//     //         Y = y;
//     //     }

//     //     public double UzaklikHesapla(Nokta digernokta)
//     //     {
//     //         return Math.Round(Math.Sqrt(Math.Pow(digernokta.X - X, 2) + Math.Pow(digernokta.Y - Y, 2)), 2);
//     //     }
//     // }
// }



// class Sekil
// {
//     public static int Birlestir(Daire d, Kare k)
//     {
//         return d._yc * d._yc * 3 + k._k * k._k;
//     }
//     // public static int Birlestir(Daire d, Daire d)
//     // {
//     //     return 0;
//     // }
//     // public static int Birlestir(Kare d, Kare k)
//     // {
//     //     return 0;
//     // }
// }

    

