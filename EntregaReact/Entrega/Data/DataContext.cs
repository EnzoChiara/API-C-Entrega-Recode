using Entrega.Model;
using Microsoft.EntityFrameworkCore;


namespace Entrega.Data{


    public class DataContext : DbContext {


        public DataContext(DbContextOptions<DataContext>options): base(options){

        }

        public DbSet<Entregas> Entrega {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
        
          
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entregas>().HasData(
                new Entregas {IDUsuario = 1, Nome = "Lucas ", Sobrenome = "Renó",FotoPerfil = "https://thumbs2.imgbox.com/60/44/H7Zzi2TT_t.jpeg" ,Email = "lucasreno@gmail.com",Senha="marechalr6",Contato="11998751632"},
                new Entregas {IDUsuario = 2, Nome = "Henrique ", Sobrenome = "Faria",FotoPerfil = "https://thumbs2.imgbox.com/7a/38/wdCxVgSk_t.jpeg" ,Email = "henriquefaria@gmail.com",Senha="niner6",Contato="11996290461"},
                new Entregas {IDUsuario = 3, Nome = "Enzo ", Sobrenome = "Chiaramonte",FotoPerfil = "https://thumbs2.imgbox.com/16/95/iD9v1mWN_t.jpeg" ,Email = "enzochiara@gmail.com",Senha="texugor6",Contato="119987142390"},
                new Entregas {IDUsuario = 4, Nome = "Nadine ", Sobrenome = "Souza",FotoPerfil = "https://thumbs2.imgbox.com/9a/af/fbs18nO2_t.jpeg" ,Email = "nadinesouza@gmail.com",Senha="nadiner6",Contato="119056718302"}
            );
                   }
    }



}

