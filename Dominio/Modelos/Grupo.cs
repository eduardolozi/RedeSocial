using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class Grupo
    {
        public string Id { get; set; }
        public string NomeGrupo { get; set; }
        public List<Midia>? HistoricoDeMidia { get; set; }
        public List<Usuario> Membros { get; set; }
    }
}
