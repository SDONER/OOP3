using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {

            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı");
        }

        public void DoItSomthing()
        {
            throw new NotImplementedException();
        }
    }
}
