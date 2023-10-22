using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WpfApp2.bd
{
    public partial class user03Context : DbContext
    {
        public user03Context()
        {
        }
        static user03Context Instance;

        public static user03Context GetInstance()
        {
            if (Instance == null);
            Instance = new user03Context();
            return Instance;

        }

        public user03Context(DbContextOptions<user03Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Magazine> Magazines { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=192.168.200.35;database=user03;user=user03;password=97965; TrustServerCertificate=true ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Magazine>(entity =>
            {
                entity.ToTable("magazine");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria).HasColumnName("categoria");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Proizvodstvo).HasColumnName("proizvodstvo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
