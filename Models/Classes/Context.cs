using Microsoft.EntityFrameworkCore;

namespace Staj_Projesi_1.Models.Classes
{
        public class Context : DbContext
        {
            public Context(DbContextOptions<Context> options) : base(options) { }

            public DbSet<Admin> Admins { get; set; }
            public DbSet<Category> Categorys { get; set; } 
            public DbSet<Currents> Currentss { get; set; }  
            public DbSet<Department> Departments { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Invoice> Invoices { get; set; }
            public DbSet<InvoiceItems> InvoiceItemss { get; set; } 
            public DbSet<Outgoings> Outgoingss { get; set; } 
            public DbSet<Products> Productss { get; set; } 
            public DbSet<SalesAction> SalesActions { get; set; }

        // Fluent API kullanarak sütun adlarını elle eşleştirme
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // SalesAction ve Product arasında ilişki
            modelBuilder.Entity<SalesAction>()
                .HasOne(s => s.Products)
                .WithMany(p => p.SalesActions)
                .HasForeignKey(s => s.ProductID);

            // SalesAction ve Current arasında ilişki
            modelBuilder.Entity<SalesAction>()
                .HasOne(s => s.Currents)
                .WithMany(c => c.SalesActions)
                .HasForeignKey(s => s.CurrentID);

            // SalesAction ve Employee arasında ilişki
            modelBuilder.Entity<SalesAction>()
                .HasOne(s => s.Employee)
                .WithMany(e => e.SalesActions)
                .HasForeignKey(s => s.EmployeeID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID);

            base.OnModelCreating(modelBuilder);
        }

    }

 }

