using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //Interfaceses
        static void Main(string[] args)
        {
            //** ICreditManager dan referans alındı...//**//
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            AplicationManager aplicationManager  = new AplicationManager(); 
            aplicationManager.MakeAnApplication(mortgageCreditManager, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager};
            //aplicationManager.CreditInfo(credits);



            //**1.Yöntem iptal**//
            // PersonalCreditManager personalCreditManager = new PersonalCreditManager();
            //** personalCreditManager.Calculate(); **Aşağıda Referans alındı bu satır aşağıdan silindi.

            // TransportCreditManager transportCreditManager = new TransportCreditManager();
            //**transportCreditManager.Calculate(); **Aşağıda Referans alındı bu satır aşağıdan silindi.

            // MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //** mortgageCreditManager.Calculate(); **Aşağıda Referans alındı bu satır aşağıdan silindi.





        }
    }
}
