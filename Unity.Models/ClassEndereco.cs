using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unity.Models
{
    public class ClassEndereco
    {           
        public int IdEndereco{ get; set; }        
        public string Cep { get; set; } = string.Empty;        
        public string Logradouro { get; set; } = string.Empty;        
        public string Numero { get; set; } = string.Empty;       
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Referencia { get; set; } = string.Empty;
        
        public Guid IdUsuario { get; set; }
        public ClassUsuario Usuario { get; set; } = new ClassUsuario();
    }
}
