using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Grupo
    {
        public int Id { get; set; }
        public string NomeGrupo { get; set; }
        public List<Midia>? HistoricoDeMidia { get; set; }
        public List<UsuarioGrupo> Membros { get; set; }
    }
}
