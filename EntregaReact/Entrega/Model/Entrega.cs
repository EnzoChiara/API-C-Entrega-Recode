using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entrega.Model{

[Table("Usuario")]
 public class Entregas{

[Column("IDUsuario")]
[Key]
public int IDUsuario {get; set;}

[Column("FotoPerfil")]
public required string FotoPerfil {get; set;}

[Column("nome")]
public string Nome {get; set;} = string.Empty;

[Column("sobrenome")]
public string Sobrenome {get; set;} = string.Empty;

[Column("email")] 
public string Email {get; set;} = string.Empty;

[Column("senha")]
public string Senha {get; set;} = string.Empty;

[Column("informacoesContato")]
public string Contato {get; set;} = string.Empty;

        
    }   
}