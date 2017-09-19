namespace OnlineShop.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblStorageLocation")]
    public partial class TblStorageLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblStorageLocation()
        {
            TblQuantityStocks = new HashSet<TblQuantityStock>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Storage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblQuantityStock> TblQuantityStocks { get; set; }
    }
}
