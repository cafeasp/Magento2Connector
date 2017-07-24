using MG2Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetToken("yourUserName", "yourPassword");
        }

        static void GetToken(string userName,string passWord)
        {
            var m2 = new Magento("http://yourIpAddress");
            string token = m2.GetAdminToken(userName, passWord);


        }
    }
}
