using ExperienceIst.Entities.Concrate;

using Microsoft.EntityFrameworkCore;

namespace ExperienceIst.DataAccess.Concrate
{
    public class ExperienceIstContext : DbContext
    {
        public ExperienceIstContext(DbContextOptions<ExperienceIstContext> options) : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Veritabanı bağlantı dizesi ve diğer ayarlar burada yapılır
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=ExperienceIst;integrated security=SSPI", options =>
                {
                    options.UseRelationalNulls();
                    options.MigrationsHistoryTable("__EFMigrationsHistory");
                    options.EnableRetryOnFailure();
                    options.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds);
                });
            }
        }
    }
}
