namespace UnityApp.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Referencia { get; set; } = string.Empty;

        public Guid IdUsuario { get; set; }
        public User Usuario { get; set; } = new User();
    }
}
