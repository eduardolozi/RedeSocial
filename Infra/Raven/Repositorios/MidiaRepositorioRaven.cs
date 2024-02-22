using Dominio.IRepositorios;
using Dominio.Modelos;
using Raven.Client.Documents;

namespace Infra.Raven.Repositorios
{
    public class MidiaRepositorioRaven : IMidiaRepositorio
    {
        private readonly IDocumentStore _store;
        public MidiaRepositorioRaven(IDocumentStore store)
        {
            _store = store;
        }

        public IEnumerable<Midia> ObterTodos(string? filtro)
        {
            var session = _store.OpenSession();
            return null;
        }
        public Midia ObterPorId(string id)
        {
            var session = _store.OpenSession();

            return null;
        }
        public void Criar(Midia midia)
        {
            var session = _store.OpenSession();

        }
        public void Atualizar(Midia midia)
        {
            var session = _store.OpenSession();

        }
        public void Remover(string id)
        {
            var session = _store.OpenSession();

        }
    }
    //public Guid Id { get; set; }
    //public byte[] Conteudo { get; set; }
    //public string Extensao { get; set; }
    //public TimeSpan? Duracao { get; set; }
    //public Guid GrupoId { get; set; }
    //public Grupo Grupo { get; set; }
    //public Guid PostagemId { get; set; }
    //public Postagem Postagem { get; set; }
}
