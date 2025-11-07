using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaDataAccessLayer.Context
{
    public class PassaparollaContext : DbContext
    {
        public PassaparollaContext() : base("PassaparollaContext") { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Sorular> Sorulars { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sorular>().HasKey(k => k.ID);
            modelBuilder.Entity<Sorular>().Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Sorular>().Property(p => p.Soru).HasColumnType("varchar").HasMaxLength(500);
            modelBuilder.Entity<Sorular>().Property(p => p.Harf).HasMaxLength(1).IsFixedLength().HasColumnType("char");


            modelBuilder.Entity<Admin>().HasKey(k => k.ID);
            modelBuilder.Entity<Admin>().Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Admin>().Property(p => p.KullanıcıAdı).HasColumnType("varchar").HasMaxLength(15);
            modelBuilder.Entity<Admin>().Property(p => p.Sıfre).HasColumnType("varchar").HasMaxLength(5);
            modelBuilder.Entity<Admin>().Property(p => p.Sıfre).HasColumnType("varchar").HasMaxLength(5);

            modelBuilder.Entity<Admin>().Property(p => p.AD).HasColumnType("varchar").HasMaxLength(15);
            modelBuilder.Entity<Admin>().Property(p => p.SOYAD).HasColumnType("varchar").HasMaxLength(15);

            modelBuilder.Entity<Role>().HasKey(k => k.ID);
            modelBuilder.Entity<Role>().Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Role>().Property(p => p.RoleType).HasColumnType("varchar").HasMaxLength(10);


            base.OnModelCreating(modelBuilder);
        }
    }
}
