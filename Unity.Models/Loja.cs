using System.ComponentModel.DataAnnotations;

namespace Unity.Models
{
    public class Loja
    {
        [Key]
        public Guid IdLoja { get; set; }
        
        public int Cnpj { get; set; }
    }
}
