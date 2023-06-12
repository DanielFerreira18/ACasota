using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ACasotaBlazorServer.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
		public DbSet<Event> Events { get; set; }
		public DbSet<EventUser> EventUsers { get; set; }
		public DbSet<Animal> Animals { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<AdoptionHouse> AdoptionHouses { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Animal>()
                .HasOne(u => u.User)
                .WithMany(u => u.Animals)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Adoption>()
                .HasOne(u => u.Animal)
                .WithMany(u => u.Adoptions)
                .HasForeignKey(u => u.AnimalId);

            builder.Entity<Adoption>()
                .HasOne(u => u.User)
                .WithMany(u => u.Adoptions)
                .HasForeignKey(u => u.UserId);

            builder.Entity<AdoptionHouse>()
                .HasOne(u => u.Type)
                .WithMany(u => u.Houses)
                .HasForeignKey(u => u.TypeId);

            builder.Entity<Adoption>()
                .HasOne(u => u.House)
                .WithMany(u => u.Adoptions)
                .HasForeignKey(u => u.HouseId);

            builder.Entity<EventUser>()
                .HasKey(u => new {u.UserId, u.EventId});

            builder.Entity<EventUser>()
				.HasOne(u => u.Event)
				.WithMany(u => u.EventUsers)
				.HasForeignKey(u => u.EventId);

			builder.Entity<EventUser>()
				.HasOne(u => u.User)
				.WithMany(u => u.EventUsers)
				.HasForeignKey(u => u.UserId);

            var idRoleUser = Guid.NewGuid().ToString();
            var idRoleAdmin = Guid.NewGuid().ToString();
            var idUserUser = Guid.NewGuid().ToString();
            var idUserAdmin = Guid.NewGuid().ToString();
            var idAnimalUser = Guid.NewGuid().ToString();
            var idAnimalAlone = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = idRoleUser, Name = "User", NormalizedName = "USER" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = idRoleAdmin, Name = "Admin", NormalizedName = "ADMIN" });

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = idUserUser,
                FirstName = "User",
                LastName = "User",
                Sex = "Masculino",
                Date_Birth = DateTime.Now,
                Email = "user@user.com",
                IsEnabled = true,
                NormalizedEmail = "USER@USER.COM",
                UserName = "user@user.com",
                NormalizedUserName = "USER@USER.COM",
                PasswordHash = hasher.HashPassword(null, "userpass"),
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = idUserAdmin,
                FirstName = "Admin",
                LastName = "Admin",
                Sex = "Masculino",
                Date_Birth = DateTime.Now,
                Email = "admin@admin.com",
                IsEnabled = true,
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                PasswordHash = hasher.HashPassword(null, "adminpass"),
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = idUserUser,
                RoleId = idRoleUser
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = idUserAdmin,
                RoleId = idRoleAdmin
            });

            builder.Entity<Animal>().HasData(new Animal
            {
                Id = idAnimalUser,
                Name = "Lucas",
                Age = "Baby",
                Race = "Cat",
                Sex = "Male",
                Size = "Little",
                IsSterile = false,
                IsVacinated = false,
                UserId = idUserUser
            });

            builder.Entity<HouseType>().HasData(new HouseType
            {
                Id = 1,
                Type = "Apartamento"
            });

            builder.Entity<HouseType>().HasData(new HouseType
            {
                Id = 2,
                Type = "Moradia, sem exterior"
            });

            builder.Entity<HouseType>().HasData(new HouseType
            {
                Id = 3,
                Type = "Moradia, com exterior"
            });
        }
    }
}