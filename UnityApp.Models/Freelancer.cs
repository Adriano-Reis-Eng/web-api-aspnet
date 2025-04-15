namespace UnityApp.Models
{
    public class Freelancer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } 
        public ICollection<Disponibilidade> Disponibilidades { get; set; } = new List<Disponibilidade>();
    }
}
