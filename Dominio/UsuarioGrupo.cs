﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UsuarioGrupo
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
    }
}
