using Bigon1.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Logging;

namespace Bigon1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options) { }



        public DbSet<Category> Categories { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var item in datas)
            {
                switch (item.State)
                {
                    case EntityState.Modified:
                        item.Entity.EditedAt = DateTime.Now;
                        break;
                    case EntityState.Added:
                        item.Entity.CreatedAt = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }

            


            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
