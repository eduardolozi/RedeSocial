﻿using Dominio.IRepositorios;
using Dominio.Modelos;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Raven.Repositorios
{
    public class UsuarioRepositorioRaven : IUsuarioRepositorio
    {
        private IDocumentStore _store;
        public UsuarioRepositorioRaven(IDocumentStore store)
        {
            _store = store;
        }
        public IEnumerable<Usuario> ObterTodos(string? filtro)
        {
            using IDocumentSession session = _store.OpenSession();
            return (filtro != null) ? session.Query<Usuario>().Where(x => x.UserName == filtro).ToList() : session.Query<Usuario>().ToList();
        }
        public Usuario ObterPorId(string id)
        {
            using IDocumentSession session = _store.OpenSession();
            return session.Load<Usuario>(id);
        }
        public void Criar(Usuario usuario)
        {
            using IDocumentSession session = _store.OpenSession();
            usuario.Id = Guid.NewGuid().ToString();
            session.Store(usuario);
            session.SaveChanges();
        }
        public void Atualizar(Usuario usuario)
        {
            using IDocumentSession session = _store.OpenSession();
            var usuarioNoBanco = session.Load<Usuario>(usuario.Id);
            if(usuarioNoBanco != null)
            {
                usuarioNoBanco.UserName = usuario.UserName;
                usuarioNoBanco.Email = usuario.Email;
                usuarioNoBanco.Senha = usuario.Senha;
                usuarioNoBanco.DataNascimento = usuario.DataNascimento;
                usuarioNoBanco.FotoPerfil = usuario.FotoPerfil;
                usuarioNoBanco.Postagens = usuario.Postagens;
                usuarioNoBanco.Seguidores = usuario.Seguidores;
                usuarioNoBanco.Seguindo = usuario.Seguindo;
                usuarioNoBanco.Grupos = usuario.Grupos;
            }
            session.SaveChanges();
        }
        public void Remover(string id)
        {
            using IDocumentSession session = _store.OpenSession();
            session.Delete(id);
            session.SaveChanges();
        }
    }
}