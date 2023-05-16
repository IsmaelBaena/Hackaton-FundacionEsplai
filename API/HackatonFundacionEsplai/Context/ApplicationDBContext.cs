using HackatonFundacionEsplai.Entities;
using Microsoft.EntityFrameworkCore;

namespace HackatonFundacionEsplai.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}
