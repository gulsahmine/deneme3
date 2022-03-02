namespace Usem.OrnekSiniflar
{
    class KisiTest
    {
        public static int nufus;
        public readonly string ad;
        public int id;
        //constructor
          public KisiTest(string name)
        {
            Dogdu(); // implementation detail / gerçekleştirme  ayrıntısı
        }

        // 
        private void Dogdu()
        {
            nufus++;
        }

    }

}