
using Microsoft.EntityFrameworkCore;
using Unity.Models;

namespace Unity.WebApi.DataContext
{
    public class UnityDbContext : DbContext
    {
        public UnityDbContext() { }

        public UnityDbContext(DbContextOptions options) : base(options) {}       

        public DbSet<ClassUsuario> Usuarios { get; set; }
        public DbSet<ClassEndereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você configura o Fluent API se quiser (exemplo abaixo)
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClassEndereco>(entity =>
            {
                entity.ToTable("enderecos");
                entity.HasKey(e => e.IdEndereco);
                entity.Property(e => e.Cep).HasMaxLength(9);
                entity.Property(e => e.Logradouro).HasMaxLength(100);
                entity.Property(e => e.Numero).HasMaxLength(5);
                entity.Property(e => e.Complemento).HasMaxLength(50);
                entity.Property(e => e.Bairro).HasMaxLength(9);
                entity.Property(e => e.Referencia).HasMaxLength(150);
                
                entity.HasOne(e => e.Usuario)
                      .WithMany(e => e.Endereco)
                      .HasForeignKey(e => e.IdUsuario)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            
            modelBuilder.Entity<ClassUsuario>(entity =>
            {
                entity.ToTable("usuarios");
                entity.HasKey(u => u.IdUsuario);
                entity.Property(u => u.Nome).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Senha).IsRequired().HasMaxLength(12);
                entity.Property(u => u.TipoUsuario).IsRequired();
                entity.Property(u => u.DataCadastro).IsRequired();               
            });            
        }
    }
}
