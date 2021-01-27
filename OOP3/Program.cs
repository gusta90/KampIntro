using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService, fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager, loggers);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            //basvuruManager.BasvuruYap(tasitKrediManager, loggers);

            List <IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
