namespace OnlineShop.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblAssortment")]
    public partial class TblAssortment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblAssortment()
        {
            TblQuantityStocks = new HashSet<TblQuantityStock>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Article { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int? IdBrand { get; set; }

        public virtual TblBrend TblBrend { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblQuantityStock> TblQuantityStocks { get; set; }
    }
}
