using Dominio.IRepositorios;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQLServer.Repositorios
{
    public class UsuarioRepositorioSQL : IUsuarioRepositorio
    {
        public IEnumerable<Usuario> ObterTodos(string? filtro) 
        {
            return null;
        }
        public Usuario ObterPeloNome(string nome)
        { 
            return null;
        }
        public Usuario ObterPorId(string id)
        {
            return null;
        }
        public void Criar(Usuario usuario)
        {
        }
        public void Atualizar(Usuario usuario)
        {
        }
        public void Remover(string id)
        {
        }
    }
}
