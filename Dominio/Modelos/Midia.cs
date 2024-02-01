using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class Midia
    {
        public Guid Id { get; set; }
        public byte[] Conteudo { get; set; }
        public string Extensao { get; set; }
        public TimeSpan? Duracao { get; set; }
        public Guid GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public Guid PostagemId { get; set; }
        public Postagem Postagem { get; set; }
    }
}
