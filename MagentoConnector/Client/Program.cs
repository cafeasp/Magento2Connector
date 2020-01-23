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
        static private string Token = ConfigurationManager.AppSettings["Token"];
        static private string ip = ConfigurationManager.AppSettings["IP"];
        static private string baseUrl = "";
        static void Main(string[] args)
        {
            string user = ConfigurationManager.AppSettings["userName"];
            string passWord = ConfigurationManager.AppSettings["passWord"];
            baseUrl = string.Format("http://{0}", ip);
            // GetToken(user, passWord);
            // GetSku("Laptop15Red", Token);
            //CreateCategory("Dominos");

            UpdateProductQty();
        }

        static void GetToken(string userName,string passWord)
        {
            var m2 = new Magento(baseUrl);
            string token = m2.GetAdminToken(userName, passWord);


        }

        static void GetSku(string skuName,string token)
        {
            var magento = new Magento("http://34.203.130.77");
            magento.GetSku(token, skuName);
        }

        static void CreateCategory(string name)
        {
            var magento = new Magento(baseUrl,Token);
            magento.CreateCategory(name);
        }

        static void UpdateProductQty()
        {
            var magento = new Magento(baseUrl, Token);

            var update_this_sku = new SkuUpdate();

            var sku = new StockItem();
            sku.Qty = 6396;
            sku.ItemId = 1;
            sku.IsInStock = true;

            update_this_sku.StockItem = sku;

            var result = magento.UpdateProductQty(update_this_sku, "ProductOne");

        }
    }
}
