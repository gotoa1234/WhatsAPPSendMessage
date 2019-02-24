using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WhatsAPPSendConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            string whatsappRecivePhones = "發送對象的電話號碼例如";
            string userName = "您的Account SID";
            string authToken = "您的Token";
            string whatsappSandBox = "whatsapp:+14155238886";
            string messageString = "Hello 這是仙草奶綠 Twilio 測試";
            //設定登入帳號
            TwilioClient.Init(
                userName,
                authToken
            );

            //發送對象
            try
            {
                var message = MessageResource.Create(
                    from: whatsappSandBox,
                    to: $"whatsapp:{whatsappRecivePhones}",
                    body: $"{DateTime.Now} => 訊息:{messageString} "
                );
                Thread.Sleep(1500);//停頓1.5秒
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
    }
}
