using System;


namespace calisma14
{
     class Daire:Sekil,IAlanHesaplanir
    {
      public int _yc;

        public Daire(int yc)
        {
            _yc = yc;
        }
         public int AlanHesapla()
        {
            return _yc * _yc * 3;
        }

    }
      
}
