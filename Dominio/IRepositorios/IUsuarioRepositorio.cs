using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositorios
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        public IEnumerable<Usuario> ObterTodos();
        public Usuario ObterPeloNome(string nome);
        public Usuario ObterPorId(string id);
        public void Criar(Usuario usuario);
        public void Atualizar(Usuario usuario);
        public void Remover(string id);
    }
}
