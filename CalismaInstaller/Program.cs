using System;

namespace CalismaInstaller
{
   
    interface ILog
    {
        void LogInfo(LogInfoType l);
        void LogError(LogErrorType l);

    }
   
   
   
   
   
   
    class Program
    {
        static void Main(string[] args)
        {
          var myLogger = new Logger();
            var myNewLogger = new LoggerFile();
            var x = new LoggerX();
            

            var ins = new Installer(x);

            ins.Install();
        }
    }
}
