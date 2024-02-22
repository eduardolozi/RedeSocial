using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositorios
{
    public interface IRepositorio<T> where T : class
    {
        public IEnumerable<T> ObterTodos(string? filtro);
        public T ObterPorId(string id);
        public void Criar(T entidade);
        public void Atualizar(T entidade);
        public void Remover(string id);
    }
}
