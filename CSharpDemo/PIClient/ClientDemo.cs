using CSharpDemo.Utility;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace CSharpDemo.PIClient
{
    public class ClientDemo
    {
        public String GetDemoResult()
        {
            //this.Url = "http://xgpidev01.itdtest.internal:50001/XISOAPAdapter/MessageServlet?senderParty=&senderService=BS_NET&receiverParty=&receiverService=&interface=SI_TM2NET_Out&interfaceNamespace=urn%3Agmk%3Atm_v1";
            //this.Credentials = new NetworkCredential("GMK_PI_USER", "gmk2016!");
            ////client.Credentials = new NetworkCredential(ConfigurationHelper.SapPiUsername, ConfigurationHelper.SapPiPassword);
            //this.Timeout = 2000;
            //this.Invoke("", new object[] { new SI_TM2NET_OutRequest()
            //{
            //    MT_TM2NET = new DT_TM2NET()
            //    {

            //    }
            //} });


            #region 二
            for (var i = 0; i < 100; i++)
            {
                Task.Run(() =>
                {
                    var index = 0;

                    BasicHttpBinding binding = new BasicHttpBinding();
                    binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
                    binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                    binding.MaxReceivedMessageSize = 65536 * 10000;
                    binding.ReceiveTimeout = new TimeSpan(0, 2, 0);
                    binding.SendTimeout = new TimeSpan(0, 3, 0);
                    EndpointAddress endpoint = new EndpointAddress("http://xgpidev01.itdtest.internal:50000/XISOAPAdapter/MessageServlet?senderParty=&senderService=BS_NET&receiverParty=&receiverService=&interface=SI_TM2NET_Out&interfaceNamespace=urn%3Agmk%3Atm_v1");

                    //WSHttpBinding myBinding = new WSHttpBinding();
                    //myBinding.Security.Mode = SecurityMode.Transport;
                    //myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                    //EndpointAddress endpoint = new EndpointAddress("https://xgpidev01.itdtest.internal:50001/XISOAPAdapter/MessageServlet?senderParty=&senderService=BS_NET&receiverParty=&receiverService=&interface=SI_TM2NET_Out&interfaceNamespace=urn%3Agmk%3Atm_v1");
                    var client = new PIClient.SI_TM2NET_OutClient(binding, endpoint);

                    client.ClientCredentials.UserName.UserName = "GMK_PI_USER";
                    client.ClientCredentials.UserName.Password = "gmk2016!";

                    var param2 = new PIClient.DT_TM2NET()
                    {
                        Point = "P20", //"P20"
                        WFID = "ZTM0000001", //"ZTM0000001"
                        XmlKey = "",
                        XmlDataIn = "",
                        XmlDataOut = "",
                        XmlEx = "",

                    };

                    LogHelper.LogInformation("call start: " + index);

                    client.SI_TM2NET_Out(ref param2);
                    LogHelper.LogInformation("call end" + index);
                });
            }

            //var param = new PIClient.SI_TM2NET_OutRequest()
            //{
            //    MT_TM2NET = new PIClient.DT_TM2NET()
            //    {
            //        Point = "11",
            //        WFID = "22",
            //        XmlDataIn = "33",
            //        XmlDataOut = "44",
            //        XmlEx = "55",
            //        XmlKey = "002",
            //    }
            //};
            //var vv = client.SI_TM2NET_OutAsync(param);

            #endregion

            return "";
        }
    }
}
