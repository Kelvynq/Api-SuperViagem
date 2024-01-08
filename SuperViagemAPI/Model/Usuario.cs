using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SuperViagemAPI.Model
{

    [Table("usuario")]
public class Usuario{

    [Column("id")]
    public int Id { get; set;}

    [Column("usuario_nome")]
    public string Nome { get; set;} = string.Empty;

    [Column("usuarioURL")]
    public string UsuarioURL { get; set;} = string.Empty;

    [Column("usuario_email")]
    public string Email { get; set;} = string.Empty;

    [Column("usuario_senha")]
    public string senha { get; set;} = string.Empty;




}
}