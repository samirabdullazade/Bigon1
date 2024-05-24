using Microsoft.EntityFrameworkCore;

namespace Bigon1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options) { }

    }
}
