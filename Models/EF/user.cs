namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [Key]
        public int us_id { get; set; }

        [Required]
        [StringLength(255)]
        public string us_name { get; set; }

        [Required]
        [StringLength(255)]
        public string us_email { get; set; }

        [Required]
        [StringLength(255)]
        public string us_password { get; set; }

        public int us_level { get; set; }
    }
}
