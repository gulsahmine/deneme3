using System;

namespace Kutuphane
{
    class Islem
    {
          public static void Alma(Kitap k, Uye u)
        {
            k.Uyeler.Add(u);
            u.Kitaplar.Add(k);
            Console.WriteLine($" {u.Ad} ödünç aldı. {k.Ad}");
        }

        public static void Iade(Kitap k, Uye u)
        {
            k.Uyeler.Remove(u);
            Console.WriteLine($" {u.Ad} iade etti. {k.Ad}");
        }
        
        
    }
}