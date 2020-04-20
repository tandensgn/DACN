namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orderdetail")]
    public partial class orderdetail
    {
        [Key]
        public int ord_id { get; set; }

        public int or_id { get; set; }

        public int prod_id { get; set; }

        public int ord_qty { get; set; }

        public int ord_price { get; set; }

        public int ord_sale { get; set; }

        public int ord_total { get; set; }

        public virtual order order { get; set; }

        public virtual product product { get; set; }
    }
}
