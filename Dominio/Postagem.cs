﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Postagem
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public List<Midia> Conteudo { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
