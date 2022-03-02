using System;

namespace CalismaInstaller
{
    class Logger: ILog
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
            GoruntuleInfo(mesaj);
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

            GoruntuleError(mesaj);
        }

        private void GoruntuleError(string m)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{DateTime.Now} : {m}");
            Console.ResetColor();
        }

        private void GoruntuleInfo(string m)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{DateTime.Now} : {m}");
            Console.ResetColor();
        }
    }
}