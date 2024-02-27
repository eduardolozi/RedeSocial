using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositorios
{
    public interface IUsuarioRepositorio
    {
        public IEnumerable<Usuario> ObterTodos(string? filtro);
        public Usuario ObterPorId(string id);
        public Usuario ObterPeloUserNameCompleto(string userName);
        public IEnumerable<Usuario> ObterTodosOsSeguidores(string id);
        public IEnumerable<Usuario> ObterTodosOsSeguindo(string id);
        public void Criar(Usuario usuario);
        public void Atualizar(Usuario usuario);
        public void Remover(string id);
    }
}
