using Dominio.IRepositorios;
using Infra.Raven.Repositorios;
using Infra.SQLServer.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Raven.Client.Documents;
using System.Security.Cryptography.X509Certificates;

namespace Infra.ModuloDeInjecao
{
    public static class Injecao
    {
        public static IServiceCollection AddRavenDB(this IServiceCollection servicesCollection)
        {
            servicesCollection.TryAddSingleton<IDocumentStore>(ctx =>
            {
                var certificatePath = $@"C:\free.eduardoellozi.client.certificate.pfx";

                var store = new DocumentStore
                {
                    Urls = new string[] { "https://a.free.eduardoellozi.ravendb.cloud" },
                    Database = "RedeSocial",
                    Certificate = new X509Certificate2(certificatePath, "")
                }; 

                store.Initialize();

                return store;
            });

            return servicesCollection;
        }

        public static IServiceCollection AddRavenRepositories(this IServiceCollection servicesCollection)
        {
            servicesCollection.TryAddScoped<IUsuarioRepositorio, UsuarioRepositorioRaven>();
            servicesCollection.TryAddScoped<IMidiaRepositorio, MidiaRepositorioRaven>();
            servicesCollection.TryAddScoped<IPostagemRepositorio, PostagemRepositorioRaven>();
            servicesCollection.TryAddScoped<IGrupoRepositorio, GrupoRepositorioRaven>();

            return servicesCollection;
        }
        
        public static IServiceCollection AddSQLServerRepositories(this IServiceCollection servicesCollection)
        {
            servicesCollection.TryAddScoped<IUsuarioRepositorio, UsuarioRepositorioSQL>();
            servicesCollection.TryAddScoped<IMidiaRepositorio, MidiaRepositorioSQL>();
            servicesCollection.TryAddScoped<IPostagemRepositorio, PostagemRepositorioSQL>();
            servicesCollection.TryAddScoped<IGrupoRepositorio, GrupoRepositorioSQL>();

            return servicesCollection;
        }
    }
}
