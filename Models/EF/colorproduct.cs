namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("colorproduct")]
    public partial class colorproduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cop_id { get; set; }

        public int prod_id { get; set; }

        public int co_id { get; set; }

        public virtual colorlist colorlist { get; set; }

        public virtual product product { get; set; }
    }
}
