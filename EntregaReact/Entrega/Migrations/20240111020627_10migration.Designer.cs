﻿// <auto-generated />
using Entrega.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entrega.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240111020627_10migration")]
    partial class _10migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entrega.Model.Entregas", b =>
                {
                    b.Property<int>("IDUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDUsuario");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("informacoesContato");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FotoPerfil");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sobrenome");

                    b.HasKey("IDUsuario");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            IDUsuario = 1,
                            Contato = "11998751632",
                            Email = "lucasreno@gmail.com",
                            FotoPerfil = "https://thumbs2.imgbox.com/60/44/H7Zzi2TT_t.jpeg",
                            Nome = "Lucas ",
                            Senha = "marechalr6",
                            Sobrenome = "Renó"
                        },
                        new
                        {
                            IDUsuario = 2,
                            Contato = "11996290461",
                            Email = "henriquefaria@gmail.com",
                            FotoPerfil = "https://thumbs2.imgbox.com/7a/38/wdCxVgSk_t.jpeg",
                            Nome = "Henrique ",
                            Senha = "niner6",
                            Sobrenome = "Faria"
                        },
                        new
                        {
                            IDUsuario = 3,
                            Contato = "119987142390",
                            Email = "enzochiara@gmail.com",
                            FotoPerfil = "https://thumbs2.imgbox.com/16/95/iD9v1mWN_t.jpeg",
                            Nome = "Enzo ",
                            Senha = "texugor6",
                            Sobrenome = "Chiaramonte"
                        },
                        new
                        {
                            IDUsuario = 4,
                            Contato = "119056718302",
                            Email = "nadinesouza@gmail.com",
                            FotoPerfil = "https://thumbs2.imgbox.com/9a/af/fbs18nO2_t.jpeg",
                            Nome = "Nadine ",
                            Senha = "nadiner6",
                            Sobrenome = "Souza"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
