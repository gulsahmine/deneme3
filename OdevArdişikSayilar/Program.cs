 using System;
using System.Collections.Generic;


namespace Ardaşıl
{
    class Program
    {
        public static void Main(string[] args)
        {
            // int sayi1, sayi2,sayi3;
            // Console.Write( "Üç tane sayı giriniz: " );
            // System.Console.WriteLine(  );
            // sayi1 = Convert.ToInt32(Console.ReadLine()) ;
            // sayi2 = Convert.ToInt32(Console.ReadLine()) ;
            // sayi3 = Convert.ToInt32(Console.ReadLine()) ;
            
            // Console.Write($"{sayi1} - {sayi2} - {sayi3}");
            // System.Console.WriteLine(  );
            // if (sayi2==sayi1 +1 && sayi3 == sayi2 +1) 
            // {
            //     System.Console.WriteLine( "Sayılar ardaşıldır.");
            // }
            // else
            // {
            //     System.Console.WriteLine( "Sayilar ardaşıl değildir.");
            // }
          
            string giris = "5-6-7-8-9-10-2";
            string[] girisler = giris.Split('-');

            int[] girislerSayi = new int[girisler.Length];

            // int çevirme
            for (int i = 0; i < girisler.Length; i++)
            {
                girislerSayi[i] = Convert.ToInt32(girisler[i]);
            }

            // Algoritma
            int onceki = girislerSayi[0];
            bool ardisil = false;

            for (int i = 1; i < girislerSayi.Length; i++)
            {
                if (girislerSayi[i] == onceki + 1)
                {
                    onceki = girislerSayi[i];
                    ardisil = true;
                }
                else
                {
                    ardisil = false;
                    break;
                }
            }

            string mesaj = ardisil ? "Ardışıl" : "Ardışıl değil";

            System.Console.WriteLine(mesaj);

        }
            
             

        }
    }

