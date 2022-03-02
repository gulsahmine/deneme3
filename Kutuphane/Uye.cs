using System.Collections.Generic;

namespace Kutuphane
{
    class Uye
    {
 // id'lerin kontrollu olarak belirlenmesi
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Uye(string ad)
        {
            Kitaplar = new List<Kitap>();
            this.Ad = ad;
        }

    }
}