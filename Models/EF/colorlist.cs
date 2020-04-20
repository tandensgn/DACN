namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("colorlist")]
    public partial class colorlist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public colorlist()
        {
            colorproducts = new HashSet<colorproduct>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_id { get; set; }

        [Required]
        [StringLength(255)]
        public string co_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colorproduct> colorproducts { get; set; }
    }
}
