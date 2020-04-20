namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            colorproducts = new HashSet<colorproduct>();
            orderdetails = new HashSet<orderdetail>();
        }

        [Key]
        public int prod_id { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_name { get; set; }

        public int prod_price { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_image { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_warranty { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_accessories { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_condition { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_promotion { get; set; }

        public int prod_status { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string prod_description { get; set; }

        public int prod_featured { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_screen { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_os { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_camf { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_camr { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_cpu { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_ram { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_Imemory { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_Ememory { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_sim { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_pin { get; set; }

        public int cate_id { get; set; }

        public virtual category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colorproduct> colorproducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderdetail> orderdetails { get; set; }
    }
}
