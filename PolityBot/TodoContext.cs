using Microsoft.EntityFrameworkCore;

namespace PolityBot
{
    public partial class TodoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=sql6004.site4now.net;Initial Catalog=DB_A404D4_ms;User Id=DB_A404D4_ms_admin;Password=rHJt7Hv3LHpu;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public virtual DbSet<UsersItem> UsersItem { get; set; }
    }
}