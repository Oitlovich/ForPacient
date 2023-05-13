using Microsoft.EntityFrameworkCore;

namespace ForPacient
{
    public class MainContext : DbContext
    {
        private static bool _initialized;
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            if (!_initialized)
            {
                _initialized = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<MedCard> MedCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new List<Role>()
            {
                new Role { Id = 1, Role_name = "Клиент"}
            });

            modelBuilder.Entity<User>().HasData(new List<User>()
            {
               new User { Id = 1, Firstname = "Alexandr", Lastname = "Romanov", Age = 10, Email = "12321@", Phone = "149032", Password = "Sanyavernysotku", RoleId = 1}
            });
            modelBuilder.Entity<MedCard>().HasData(new List<MedCard>()
            {
               new MedCard { Id = 1, Disease = "" UserId = ""}
            });
        }
    }
}
