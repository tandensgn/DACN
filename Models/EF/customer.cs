namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            orders = new HashSet<order>();
        }

        [Key]
        public int cus_id { get; set; }

        [Required]
        [StringLength(255)]
        public string cus_name { get; set; }

        public int cus_phone { get; set; }

        [Required]
        [StringLength(255)]
        public string cus_email { get; set; }

        [Required]
        [StringLength(255)]
        public string cus_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
