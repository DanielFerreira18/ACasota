using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ACasotaBlazorServer.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			var idRoleUser = Guid.NewGuid().ToString();
			var idRoleAdmin = Guid.NewGuid().ToString();
			var idUserUser = Guid.NewGuid().ToString();
			var idUserAdmin = Guid.NewGuid().ToString();

			var hasher = new PasswordHasher<IdentityUser>();

			builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = idRoleUser, Name = "User", NormalizedName="USER" });
			builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = idRoleAdmin, Name = "Admin", NormalizedName = "ADMIN" });

			builder.Entity<ApplicationUser>().HasData(new ApplicationUser
			{
				Id = idUserUser,
				FirstName = "User",
				LastName = "User",
				Date_Birth = DateTime.Now,
				Email = "user@user.com",
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
				Date_Birth = DateTime.Now,
				Email = "admin@admin.com",
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
				RoleId = idRoleUser,
			});

			builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
			{
				UserId = idUserAdmin,
				RoleId = idRoleAdmin,
			});

		}
	}
}
