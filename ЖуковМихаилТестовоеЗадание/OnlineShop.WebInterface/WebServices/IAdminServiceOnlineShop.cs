using OnlineShop.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OnlineShop.WebInterface.WebServices
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IAdminServiceOnlineShop" в коде и файле конфигурации.
    [ServiceContract]
    public interface IAdminServiceOnlineShop
    {
        [OperationContract]
        string LoadDataService(string price);

        [OperationContract]
        string BrendsForAdmin();

        [OperationContract]
        string AssortmentForAdmin();
    }
}
