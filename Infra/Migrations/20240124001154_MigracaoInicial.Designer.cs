﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240124001154_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Modelos.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeGrupo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Dominio.Modelos.Midia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Conteudo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<TimeSpan?>("Duracao")
                        .HasColumnType("time");

                    b.Property<string>("Extensao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<int>("PostagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("PostagemId");

                    b.ToTable("Midias");
                });

            modelBuilder.Entity("Dominio.Modelos.Postagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("Dominio.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FotoPerfil")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GrupoUsuario", b =>
                {
                    b.Property<int>("GruposId")
                        .HasColumnType("int");

                    b.Property<int>("MembrosId")
                        .HasColumnType("int");

                    b.HasKey("GruposId", "MembrosId");

                    b.HasIndex("MembrosId");

                    b.ToTable("GrupoUsuario");
                });

            modelBuilder.Entity("UsuarioUsuario", b =>
                {
                    b.Property<int>("SeguidoresId")
                        .HasColumnType("int");

                    b.Property<int>("SeguindoId")
                        .HasColumnType("int");

                    b.HasKey("SeguidoresId", "SeguindoId");

                    b.HasIndex("SeguindoId");

                    b.ToTable("UsuarioUsuario");
                });

            modelBuilder.Entity("Dominio.Modelos.Midia", b =>
                {
                    b.HasOne("Dominio.Modelos.Grupo", "Grupo")
                        .WithMany("HistoricoDeMidia")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Modelos.Postagem", "Postagem")
                        .WithMany("Conteudo")
                        .HasForeignKey("PostagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Postagem");
                });

            modelBuilder.Entity("Dominio.Modelos.Postagem", b =>
                {
                    b.HasOne("Dominio.Modelos.Usuario", "Usuario")
                        .WithMany("Postagens")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GrupoUsuario", b =>
                {
                    b.HasOne("Dominio.Modelos.Grupo", null)
                        .WithMany()
                        .HasForeignKey("GruposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("MembrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UsuarioUsuario", b =>
                {
                    b.HasOne("Dominio.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("SeguidoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("SeguindoId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Modelos.Grupo", b =>
                {
                    b.Navigation("HistoricoDeMidia");
                });

            modelBuilder.Entity("Dominio.Modelos.Postagem", b =>
                {
                    b.Navigation("Conteudo");
                });

            modelBuilder.Entity("Dominio.Modelos.Usuario", b =>
                {
                    b.Navigation("Postagens");
                });
#pragma warning restore 612, 618
        }
    }
}
