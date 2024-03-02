using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoExamYM.Models
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Agents> Agents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSale>()
                .Property(e => e.Products)
                .IsUnicode(false);

            modelBuilder.Entity<ProductSale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductSale>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<ProductSale>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Agents>()
                .Property(e => e.AgentType)
                .IsUnicode(false);

            modelBuilder.Entity<Agents>()
                .Property(e => e.AgentName)
                .IsUnicode(false);

            modelBuilder.Entity<Agents>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Agents>()
                .Property(e => e.Phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Agents>()
                .Property(e => e.AgentLogo)
                .IsFixedLength();

            modelBuilder.Entity<Agents>()
                .Property(e => e.Adress)
                .IsFixedLength();

            modelBuilder.Entity<Agents>()
                .Property(e => e.Priority)
                .IsFixedLength();

            modelBuilder.Entity<Agents>()
                .Property(e => e.Director)
                .IsFixedLength();

            modelBuilder.Entity<Agents>()
                .Property(e => e.TIN)
                .IsFixedLength();

            modelBuilder.Entity<Agents>()
                .Property(e => e.Checkpoint)
                .IsFixedLength();
        }
    }
}
