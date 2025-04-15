using Unity.Enums;

namespace UnityApp.Models
{
    public class User
    {
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public DateOnly DataCadastro { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public List<Endereco> Endereco { get; set; } = [];
    }
}
