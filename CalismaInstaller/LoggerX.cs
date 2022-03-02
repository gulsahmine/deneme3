namespace CalismaInstaller
{
    class LoggerX : ILog
    {
        public void LogError(LogErrorType l)
        {
            System.Console.WriteLine("aloo");
        }

        public void LogInfo(LogInfoType l)
        {
            System.Console.WriteLine("olaaa");
        }
    }

}