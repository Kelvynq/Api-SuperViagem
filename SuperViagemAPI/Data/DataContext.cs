using Microsoft.EntityFrameworkCore;
using SuperViagemAPI.Model;

namespace SuperViagemAPI.Data
{
public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
    }
public DbSet<Usuario> Usuarios {get; set;}

protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario {Id = 1, Nome = "José Pedro",  UsuarioURL = "https://cdn-icons-png.flaticon.com/512/6073/6073873.png", Email = "jose.pedro@gmail.com", senha = "jose123"},
                new Usuario {Id = 2, Nome = "Victor Diniz",  UsuarioURL = "hhtps://www.jose123.com", Email = "victor.diniz@gmail.com", senha = "victor123"},
                new Usuario {Id = 3, Nome = "Agnaldo Ribeiro",  UsuarioURL = "hhtps://www.jose123.com", Email = "agnaldo.ribeiro@gmail.com", senha = "agnaldo123"},
                new Usuario {Id = 4, Nome = "Pamela Lucia",  UsuarioURL = "hhtps://www.jose123.com", Email = "pamela.lucia@gmail.com", senha = "pamela123"},
                new Usuario {Id = 5, Nome = "Maria Ferraz",  UsuarioURL = "hhtps://www.jose123.com", Email = "maria.ferraz@gmail.com", senha = "maria123"},     
                new Usuario {Id = 6, Nome = "Vanessa Lopes",  UsuarioURL = "hhtps://www.jose123.com", Email = "vanessa.lopes@gmail.com", senha = "vanessa123"}     
            );
        }
 
}
}