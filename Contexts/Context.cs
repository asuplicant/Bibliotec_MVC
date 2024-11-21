using Microsoft.EntityFrameworkCore;


namespace Bibliotec.Contexts
{

    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<DbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Sounce=NOTE44-S28-S28\\SQLEXPRESS; Initial Catalog = Bibliotec_MVC; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");
            }
        }

        public DbSet<Categoria> Categoria { get; set; }
        //Curso
         public DbSet<Curso> Categoria { get; set; }
        //Curso, livro, usuário, livrocategoria, livroreserva
    }
}