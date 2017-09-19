namespace OnlineShop.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblQuantityStock")]
    public partial class TblQuantityStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblQuantityStock()
        {
            TblPrices = new HashSet<TblPrice>();
        }

        public Guid Id { get; set; }

        public decimal? Quantity { get; set; }

        public int? IdUnit { get; set; }

        public Guid IdPrice { get; set; }

        public Guid IdStorageLocation { get; set; }

        public virtual TblAssortment TblAssortment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblPrice> TblPrices { get; set; }

        public virtual TblStorageLocation TblStorageLocation { get; set; }
    }
}
