namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            System.Console.WriteLine("Dosyaya yüklendi.");
        }
    }
}