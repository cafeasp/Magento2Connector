using MG2Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //string user = ConfigurationManager.AppSettings["userName"];
            //string passWord = ConfigurationManager.AppSettings["passWord"];
            string Token = ConfigurationManager.AppSettings["Token"];
            // GetToken(user, passWord);
            GetSku("Laptop15Red", Token);


        }

        static void GetToken(string userName,string passWord)
        {
            var m2 = new Magento("http://34.203.130.77");
            string token = m2.GetAdminToken(userName, passWord);


        }

        static void GetSku(string skuName,string token)
        {
            var magento = new Magento("http://34.203.130.77");
            magento.GetSku(token, skuName);
        }
    }
}
