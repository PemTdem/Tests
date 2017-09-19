using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Admin.Clases
{
    
    public class Prices
    {
        //Артикул;Наименование;Бренд;Склад;Количество;"Цена руб";
        //Распродажа;"Мин. заказ";"Срок поставки (Рабочие дни)";
        //"Уцененный товар";Авиадоставка;"Товар в пути"
       // GDB3212;"Колодки передние HONDA JAZZ II 02-08 GDB3212";TRW;BERG;1;1478.92;распродажа;1;0;;;

        public string Article { get; set; }
        public string Name { get; set; }
        public string Brend { get; set; }
        public string Storage { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public bool Sale { get; set; }
        public double MinOrder { get; set; }
        public int DeliveryTime { get; set; }
        public bool DiscountedGoods { get; set; }
        public bool AirDelivery { get; set; }
        public bool GoodsTransit { get; set; }
        public int id { get; set; }

    }

}
