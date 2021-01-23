using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AplicationManager
    {
        //**Method Injection**//
        public void MakeAnApplication(ICreditManager creditManager,ILoggerService loggerservice)
        {
            //**Başvuran bilgilerini değerlendir...
            //**bu şekilde yapılırsa tüm krediler konut kredisi üzerinden hesaplanır... 
            //**Bu yanlış...** yukarıda public için ıcreditmanager referans olarak  gönderilir.//
            //**Parantez için boş olursa hangi kredi gönderilirse onun referansını almaz.

            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            mortgageCreditManager.Calculate();
            loggerservice.Log();

            //**// Doğru Olan

        }

        public void CreditInfo(List<ICreditManager> credits) //Birden fazla kredinin karşılaştırılması için liste isteniyor...**//
        {

            foreach (var credit in credits)
            {
                credit.Calculate();
            }


        }
    }
}
