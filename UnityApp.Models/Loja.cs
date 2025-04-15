namespace UnityApp.Models
{
    public class Loja
    {
        public Guid Id { get; set; }
        public int Cnpj { get; set; }
        public Byte Logotipo { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
