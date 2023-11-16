using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users {get; set;} //users es el nombre de nuestra tabla y refenciamos a la clase appuser para que coja los datos de ahi
}
