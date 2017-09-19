using Newtonsoft.Json;
using OnlineShop.Admin.AdminShopService;
using OnlineShop.Admin.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Admin.Models.Base
{
    public class BaseModel
    {
        public IEnumerable<Brend> Brends;

        public IEnumerable<Assortment> Assortment;

        public BaseModel()
        {
            AdminServiceOnlineShopClient client = new AdminServiceOnlineShopClient();

            client.Open();

            var brends = client.BrendsForAdmin();

            Brends = JsonConvert.DeserializeObject<IEnumerable<Brend>>(brends);

            Assortment = JsonConvert.DeserializeObject<IEnumerable<Assortment>>(client.AssortmentForAdmin());

            client.Close();

        }



    }
}
