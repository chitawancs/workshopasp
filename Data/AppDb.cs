namespace MshopWorkShop.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MshopWorkShop.Models;

    public partial class AppDb : IdentityDbContext<ApplicationUser>

    {
        public static AppDb Create() {
            return new AppDb();
        }
        public AppDb()
            : base("name=AppDb")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
