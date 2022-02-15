using System;
using System.Collections.Generic;
using System.Text;
using Usem.Oyunlar;

namespace Calismamm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kart> BizimDeste = DesteOlustur(); // Karıştırma opsiyonlu 
            KartDagit();
            DesteTumGoster(BizimDeste);


            // Console.OutputEncoding = Encoding.Unicode;
            // System.Console.WriteLine("\u263A"); // 


        }

        private static void KartDagit(int kisiSayisi, int kartSayisi, List<Kart> dagitilacakDeste)
        {
            // parameter kontrol :  temel kontrol 0'da buyuk. Dağıtmak mümkün mü?

            // desteden n tane kart alma işi


        }
        
        private static void DesteTumGoster( List<Kart> deste)
        {
            foreach (var k in deste)
            {
                Console.WriteLine($"{k.grup}{k.deger}");
            }
        }   
          
           
           private static List<Kart> DesteOlustur()
        {
            bool karisik;

            // 4 * 13 Deste ? 
            // Özel bir deste için veriler
           
            string[] gruplarTR = 
            {
                "maça",
                "kupa",
                "karo",
                "sinek"
            };
           
            string[] degerSimgeler = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int[] degerler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
           
            
            //Deste için veri yapısı (oyun ile ilgili)
            List<Kart> deste = new List<Kart>();
           

            foreach(var g in gruplar)
            {
                foreach(var d in degerSimgeler) //d? "A" "1"
                {
                     //Kart üret
                    Kart k = new Kart();
                    k.grup = g;
                    k.degerSimge = d;
                    k.deger =  degerler[Array.IndexOf(degerSimgeler, d)]; // d nin indeksini bul, aynı indeksi degerler dizisinde kullan 
                    k.kapali = true;
                    //Kart deste ekle
                    deste.Add (k);
                }
            }
            
             if (karisik)
            {
                deste = DesteKaristir(deste); 
                
            }
            
            return deste;
           
        }           
           private static void DesteKaristir(List<Kart> d)
           {
           // Karıştırma algoritması yaz
            var karisikDeste = d;
            Console.WriteLine("Deste karıştırıldı...");
            return karisikDeste;
           }
        }
}    
    

            

           
            

        
        
            
            
       
//     // Kart oluşturmak için reçete, Kart tipi tanımlıyor
//     class Kart
//     {
//         public string grup; //mutlaka belirlenmeli      
//         public string grupSimge; //mutlaka belirlenmeli      
//         public bool kapali; //default değer yeterli

//         //simge ve değer uyumlu olmalı
//         public string degersimge; //mutlaka belirlenmeli      
//         public int deger; //mutlaka belirlenmeli      
//     }


