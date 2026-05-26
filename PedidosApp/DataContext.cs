using Microsoft.EntityFrameworkCore;

namespace PedidosApp
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
    }
}
