using System;

namespace CalismaInstaller
{
    class LoggerFile :  ILog
    {
        public DateTime Start { get; private set; }
        public DateTime Bitis { get; private set; }

        public void LogInfo(LogInfoType secim)
        {
            string mesaj;
            switch (secim)
            {
                case LogInfoType.Start:
                    //
                    mesaj = "Kurulum başladı";
                    Start = DateTime.Now;
                    break;
                case LogInfoType.Bitti:
                    //
                    mesaj = "Kurulum bitti";
                    Bitis = DateTime.Now;
                    break;
                case LogInfoType.BirinciAsama:
                    mesaj = "Birinci aşama";
                    //
                    break;
                default:
                    mesaj = "....";
                    break;
            }

            // Görüntüleme işi
            YazdirInfo(mesaj);
        }

        public void LogError(LogErrorType secim)
        {
            string mesaj;

            switch (secim)
            {
                case LogErrorType.Hata:
                    //
                    mesaj = "Hata oluştu";
                    break;
                case LogErrorType.HataKritik:
                    //
                    mesaj = "Kiritik hata oluştu";
                    break;
                default:
                    mesaj = "!!!";
                    break;
            }

            YazdirError(mesaj);
        }

        private void YazdirError(string m)
        {
            Console.WriteLine($"{m} : Dosyaya yazıldı....");
        }

        private void YazdirInfo(string m)
        {
            Console.WriteLine($"{m} : Dosyaya yazıldı....");

        }

    }
}