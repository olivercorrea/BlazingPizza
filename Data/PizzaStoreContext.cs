
// Esta clase crea un contexto de base de datos que se puede usar para registrar un servicio de base de datos. El contexto también nos permite tener un controlador que accede a la base de datos.

using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}
