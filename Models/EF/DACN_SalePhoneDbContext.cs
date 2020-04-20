namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DACN_SalePhoneDbContext : DbContext
    {
        public DACN_SalePhoneDbContext()
            : base("name=DACN_SalePhone")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<colorlist> colorlists { get; set; }
        public virtual DbSet<colorproduct> colorproducts { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<orderdetail> orderdetails { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.cate_series)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.cate_models)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.products)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<colorlist>()
                .Property(e => e.co_name)
                .IsUnicode(false);

            modelBuilder.Entity<colorlist>()
                .HasMany(e => e.colorproducts)
                .WithRequired(e => e.colorlist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cus_email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.orderdetails)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_image)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_warranty)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_accessories)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_condition)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_promotion)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_description)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_screen)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_os)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_camf)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_camr)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_cpu)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_ram)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_Imemory)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_Ememory)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_sim)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_pin)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.colorproducts)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.orderdetails)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.us_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.us_email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.us_password)
                .IsUnicode(false);
        }
    }
}
