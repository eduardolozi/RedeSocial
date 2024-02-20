using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQLServer
{
    public class AppDbContext : DbContext
    {
        private readonly string StringDeConexao = "Data Source=EDUARDOLOZANO;Initial Catalog=RedeSocial;Persist Security Info=True;User ID=sa;Password=sap@123;TrustServerCertificate=True";

        public AppDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Midia>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Midia>()
                .Property(u => u.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Postagem>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Postagem>()
                .Property(u => u.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Grupo>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Grupo>()
                .Property(u => u.Id)
                .ValueGeneratedNever();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StringDeConexao);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Midia> Midias { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Postagem> Postagens { get; set; }

    }
}
