using Dominio.IRepositorios;
using Dominio.Modelos;
using Raven.Client.Documents;

namespace Infra.Raven.Repositorios
{
    public class MidiaRepositorioRaven : IMidiaRepositorio
    {
        private readonly IDocumentStore _store;
        private readonly IUsuarioRepositorio _usuarioRepo;
        public MidiaRepositorioRaven(IDocumentStore store, IUsuarioRepositorio usuarioRepo)
        {
            _store = store;
            _usuarioRepo = usuarioRepo;
        }

        public IEnumerable<Midia> ObterTodos(string? filtro)
        {
            var session = _store.OpenSession();

            return session.Query<Midia>().ToList();

            //var usuario = _usuarioRepo.ObterPorId(filtro);
            //if (usuario == null) return null;
            //return session.Query<Midia>().Where(x => x.Postagem.)

        }
        public Midia ObterPorId(string id)
        {
            var session = _store.OpenSession();
            return session.Load<Midia>(id);
        }
        public void Criar(Midia midia)
        {
            var session = _store.OpenSession();
            session.Store(midia);
        }
        public void Remover(string id)
        {
            var session = _store.OpenSession();
            session.Delete(id);
        }
    }
}
