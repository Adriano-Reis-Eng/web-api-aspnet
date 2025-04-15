using System.ComponentModel.DataAnnotations;
using Unity.Enums;

namespace Unity.Models
{
    public class ClassUsuario
    {        
        public Guid IdUsuario { get; set; }        
        public string Nome { get; set; } = string.Empty;        
        public string Email { get; set; } = string.Empty;        
        public string Senha { get; set; } = string.Empty;        
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public DateOnly DataCadastro { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public List<ClassEndereco> Endereco { get; set; } = [];
    }
}
