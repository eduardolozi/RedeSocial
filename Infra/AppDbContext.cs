using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class AppDbContext : DbContext
    {
        private readonly string StringDeConexao = "Data Source=EDUARDOLOZANO;Initial Catalog=RedeSocial;Persist Security Info=True;User ID=sa;Password=sap@123;TrustServerCertificate=True";

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StringDeConexao);
        }

        public DbSet<Usuario> Usuarios {  get; set; }
        public DbSet<Midia> Midias {  get; set; }
        public DbSet<Grupo> Grupos {  get; set; }
        public DbSet<Postagem> Postagens {  get; set; }

    }
}
