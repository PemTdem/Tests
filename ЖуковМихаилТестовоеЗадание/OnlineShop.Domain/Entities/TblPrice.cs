namespace OnlineShop.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblPrice")]
    public partial class TblPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblPrice()
        {
            TblStatus = new HashSet<TblStatu>();
        }

        public Guid Id { get; set; }

        public decimal? Price { get; set; }

        public Guid IdQuantity { get; set; }

        public virtual TblQuantityStock TblQuantityStock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblStatu> TblStatus { get; set; }
    }
}
