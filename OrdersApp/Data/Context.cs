using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdersApp.Models;

namespace OrdersApp.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasOne<Product>(s => s.Product)
                .WithMany(g => g.Orders)
                .HasForeignKey(s => s.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne<Client>(s => s.Client)
                .WithMany(g => g.Orders)
                .HasForeignKey(s => s.ClientId);
        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
