using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Midia
    {
        public int Id { get; set; }
        public byte[] Conteudo { get; set; }
        public string Extensao { get; set; }
        public TimeOnly? Duracao { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public int PostagemId { get; set; }
        public Postagem Postagem { get; set; }
    }
}
