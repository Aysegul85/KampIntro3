using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        private static List<ICreditManager> krediler;

        static void Main(string[] args)
        {

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
           //ihtiyacKrediManager.Hesapla();

            ICreditManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            ICreditManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();




            ILoggerService dataLoggerServise = new DatabaseLogger();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLogger(), new FilebaseLogger() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLogger());
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            basvuruManager.BasvuruYap(tasitKrediManager, dataLoggerServise);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            Console.WriteLine("...............List<ICreditManager>...........");

            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager , konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);







        }
    }
}
