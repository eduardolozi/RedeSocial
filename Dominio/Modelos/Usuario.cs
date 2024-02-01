using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public byte[]? FotoPerfil { get; set; }
        public List<Postagem>? Postagens { get; set; }
        public List<Usuario>? Seguidores { get; set; }
        public List<Usuario>? Seguindo { get; set; }
        public List<Grupo>? Grupos { get; set; }
    }
}
