using System;
using System.Threading;

namespace CalismaInstaller
{
    
    
         enum LogInfoType
        {
            Start,
            Bitti,
            BirinciAsama
        }

        enum LogErrorType
        {
            Hata,
            HataKritik,
        }

         class Installer
       {
        // Has-A-relation
        private readonly ILog _logger;

        public Installer(ILog logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            Console.ResetColor();

            bool hata = true;
            _logger.LogInfo(LogInfoType.Start);

            Console.WriteLine("KURULUM...");
            if (hata)
            {
                _logger.LogError(LogErrorType.Hata);
            }

            Thread.Sleep(1000);
            _logger.LogInfo(LogInfoType.Bitti);
        }

    }

}