using System;
using System.Collections.Generic;

namespace OdevHesap
{

    class BankaHesabi
    {
        private static int no = 1234567890;
        public string HesapNo { get; }
        public string HesapAd { get; set; }
        public int Bakiye { get; set; }
        private List<Islem> Islemler;

        public BankaHesabi(string ad)
        {
            HesapAd = ad;
            HesapNoAtama();
        }

        public BankaHesabi(string ad, int bakiye)
        {
            HesapAd = ad;
            HesapNoAtama();

            Bakiye = bakiye;
        }

        public void ParaYatir(Islem i)
        {
            Bakiye += i.Miktar;
            Islemler.Add(i);

        }
        public void ParaCek(Islem i)
        {
            Bakiye -= i.Miktar;
            Islemler.Add(i);

        }
        public void IslemGecmisi()
        {
            foreach (var i in Islemler)
            {
                Console.WriteLine($"{i.Tarih} - {i.Tip} : {i.Miktar} - {i.Not}");
            }
        }

        private void HesapNoAtama()
        {
            HesapNo = no.ToString();
            no++;
        }
    }

    class Islem
    {
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Not { get; set; }
        public string Tip { get; set; }

    }








}
