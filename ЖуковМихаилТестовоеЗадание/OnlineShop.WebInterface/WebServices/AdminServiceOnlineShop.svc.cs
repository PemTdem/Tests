using Newtonsoft.Json;
using OnlineShop.WebInterface.WebServices.Classec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OnlineShop.Services.Implementation;

namespace OnlineShop.WebInterface.WebServices
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "AdminServiceOnlineShop" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы AdminServiceOnlineShop.svc или AdminServiceOnlineShop.svc.cs в обозревателе решений и начните отладку.
    public class AdminServiceOnlineShop : IAdminServiceOnlineShop
    {
        public string AssortmentForAdmin()
        {
            AssortmentServices assort = new AssortmentServices();
            return JsonConvert.SerializeObject(assort.GetAssortments());
        }

        public string BrendsForAdmin()
        {

            BrendServices bs = new BrendServices();
            return JsonConvert.SerializeObject(bs.GetBrends());
        }

        public string LoadDataService(string price)
        {
            if (price != null)
            {
                Prices p = JsonConvert.DeserializeObject<Prices>(price);
                UpdateData ud = new UpdateData(p);
            }
            return price;
        }
    }
}
