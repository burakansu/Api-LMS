using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> dbContext)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS;Initial Catalog=LMS_Database;Integrated Security=true; Encrypt=False ");
        }
        public DbSet<TBL_Classes> Classes { get; set; }
        public DbSet<TBL_Directors> Directors { get; set; }
        public DbSet<TBL_Lessons> Lessons { get; set; }
        public DbSet<TBL_Notes> Notes { get; set; }
        public DbSet<TBL_Students> Students { get; set; }
        public DbSet<TBL_Teachers> Teachers { get; set; }
        public DbSet<TBL_Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_Classes>().ToTable("TBL_Classes");
            modelBuilder.Entity<TBL_Directors>().ToTable("TBL_Directors");
            modelBuilder.Entity<TBL_Lessons>().ToTable("TBL_Lessons");
            modelBuilder.Entity<TBL_Notes>().ToTable("TBL_Notes");
            modelBuilder.Entity<TBL_Students>().ToTable("TBL_Students");
            modelBuilder.Entity<TBL_Teachers>().ToTable("TBL_Teachers");
            modelBuilder.Entity<TBL_Users>().ToTable("TBL_Users");
        }
    }
}
