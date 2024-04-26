using cadastro_de_contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace cadastro_de_contatos.Data
{
    public class Connection : DbContext
    {
        public Connection(DbContextOptions<Connection> options) : base(options) { }

        public DbSet<ContactModel> Contact { get; set; }
    }
}
