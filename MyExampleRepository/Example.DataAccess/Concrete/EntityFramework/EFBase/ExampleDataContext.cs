using Example.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Example.DataAccess.Concrete.EntityFramework.EFBase
    {
        public class ExampleDataContext: DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }

            public ExampleDataContext()
            {
                this.Configuration.LazyLoadingEnabled = false;
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ExampleDataContext>());
            }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Product>().HasRequired<Category>(p => p.CurrentCategory).WithMany(c => c.Products).HasForeignKey<int>(p => p.CategoryId);
            }
        }
    }
