﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Dtos
{
    public record UsuarioDto
    {
        public string UserName { get; set; }
        public string Senha { get; set; }
    }
}
