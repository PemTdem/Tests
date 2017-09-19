namespace OnlineShop.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TblStatu
    {
        public Guid Id { get; set; }

        public bool? Sale { get; set; }

        public decimal? MinOrder { get; set; }

        public int? DeliveryTime { get; set; }

        public bool? DiscountedGoods { get; set; }

        public bool? AirDelivery { get; set; }

        public bool? GoodsTransit { get; set; }

        public Guid IdPrice { get; set; }

        public virtual TblPrice TblPrice { get; set; }
    }
}
