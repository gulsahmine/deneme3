using System;
namespace calisma14
{
     class Kare:Sekil, IAlanHesaplanir
    {
         private int _k;
        public Kare(int k)
        {
            _k = k;
        }

        public int AlanHesapla()
        {
            return _k * _k;
        }
              
    }
    
}