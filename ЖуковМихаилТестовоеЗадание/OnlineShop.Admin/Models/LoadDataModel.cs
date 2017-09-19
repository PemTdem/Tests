
using OnlineShop.Admin.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Admin.AdminShopService;

namespace OnlineShop.Admin.Models
{
    public class LoadDataModel
    {
        public List<Prices> listPrice { get; set; }
        public List<string[]> errlistPrice { get; set; }
        public LoadDataModel(string path)
        {
            listPrice = new List<Prices>();
            errlistPrice = new List<string[]>();
            using (StreamReader reader = new StreamReader(path))
            {
                int id = 1;
                string[] s1 = reader.ReadLine().Split(';');


                if (s1[0].ToString() == "Артикул")
                    while (!reader.EndOfStream)
                    {
                        Prices rowPrice = new Prices();
                        string[] s = null; ;
                        try
                        {
                            s = reader.ReadLine().Split(';');
                            //Добавляем в список новый экземляр класса Prices
                            rowPrice.id = id;
                            rowPrice.Article = s[0].ToString().Trim();
                            rowPrice.Name = s[1].ToString().Trim();
                            rowPrice.Brend = s[2].ToString().Trim();
                            rowPrice.Storage = s[3].ToString().Trim();
                            rowPrice.Quantity = s[4].ToString() == "" ? 0 : Convert.ToDouble(s[4].ToString().Trim().Replace('.',','));
                            rowPrice.Price = s[5].ToString() == "" ? 0 : Convert.ToDouble(s[5].ToString().Trim().Replace('.', ','));

                            rowPrice.Sale = s[6].ToString() == "" ?  false : true;

                            rowPrice.MinOrder = s[7].ToString() == "" ? 0 : Convert.ToDouble(s[7].ToString().Trim().Replace('.', ','));
                            rowPrice.DeliveryTime = s[8].ToString() == "" ? 0 : Convert.ToInt32(s[8].ToString().Trim());
                            rowPrice.DiscountedGoods = s[9].ToString() == "" ? false : Convert.ToBoolean(s[9].ToString());
                            rowPrice.AirDelivery = s[10].ToString() == "" ? false : Convert.ToBoolean(s[10].ToString());
                            rowPrice.GoodsTransit = s[11].ToString() == "" ? false : Convert.ToBoolean(s[11].ToString());
                            listPrice.Add(rowPrice);
                            

                        }
                        catch (Exception e)
                        {
                            errlistPrice.Add(s);
                        }

                        id++;

                    }
                SetDataToDB();
            }
        }

        private void SetDataToDB()
        {

            AdminServiceOnlineShopClient client = new AdminServiceOnlineShopClient();

            client.Open();

            foreach (var item in listPrice)
            {
                if (item != null)
                {
                    string req = JsonConvert.SerializeObject(item);
                    string res = client.LoadDataService(req);
                }
            }
            client.Close();
        }

    }
}
