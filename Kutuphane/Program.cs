using System;
using System.Collections.Generic;

namespace Kutuphane
{
    class Program
    {
        Dictionary<int, Kitap> kutuphane = new Dictionary<int, Kitap>();
        Dictionary<int, Uye> uyeler = new Dictionary<int, Uye>();
           
           //Key: KitapID Value:Kitap
        static void Main(string[] args)
        {
            var k = new Kitap("Bir kitap");
            var u = new Uye ("Bir üye");
            
            //kutuphane.Add (k.id,k);
            Islem.Alma(k, u);
            Islem.Alma(k, u);
            Islem.Alma(k, u);
            Islem.Alma(k, u);
            Islem.Alma(k, u);
            Islem.Alma(k, u);
            Islem.Alma(k, u);
            Islem.Alma(k, u);

            foreach (var ki in u.Kitaplar)
            {
                Console.WriteLine(ki.Ad);
            }

            foreach (var uye in k.Uyeler)
            {
                Console.WriteLine(uye.Ad);
            }

            // Islem.Iade(k, u);
            
            
           
           
        }
    }
}
