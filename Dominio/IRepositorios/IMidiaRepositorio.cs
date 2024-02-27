using Dominio.Modelos;
namespace Dominio.IRepositorios
{
    public interface IMidiaRepositorio
    {
        public IEnumerable<Midia> ObterTodos(string? filtro);
        public Midia ObterPorId(string id);
        public void Criar(Midia midia);
        public void Remover(string id);
    }
}
