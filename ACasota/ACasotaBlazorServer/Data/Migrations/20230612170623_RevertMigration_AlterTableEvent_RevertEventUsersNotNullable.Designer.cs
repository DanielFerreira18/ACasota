﻿// <auto-generated />
using System;
using ACasotaBlazorServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ACasotaBlazorServer.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230612170623_RevertMigration_AlterTableEvent_RevertEventUsersNotNullable")]
    partial class RevertMigration_AlterTableEvent_RevertEventUsersNotNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ACasotaBlazorServer.Data.Adoption", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdoptionReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("ConsentResponsability")
                        .HasColumnType("bit");

                    b.Property<bool>("HasAnimals")
                        .HasColumnType("bit");

                    b.Property<string>("HouseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("HouseId");

                    b.HasIndex("UserId");

                    b.ToTable("Adoptions");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.AdoptionHouse", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tipology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("AdoptionHouses");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Animal", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSterile")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVacinated")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = "845d2a5c-b5fd-4e48-9a7d-3b3ccb54aa4f",
                            Age = "Baby",
                            IsSterile = false,
                            IsVacinated = false,
                            Name = "Lucas",
                            Race = "Cat",
                            Sex = "Male",
                            Size = "Little",
                            UserId = "29999d65-e585-47ff-b57d-69647ee65b54"
                        });
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "29999d65-e585-47ff-b57d-69647ee65b54",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6dd3f74-1009-45f6-8c94-47491fc48d94",
                            Date_Birth = new DateTime(2023, 6, 12, 18, 6, 23, 100, DateTimeKind.Local).AddTicks(7037),
                            Email = "user@user.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            IsEnabled = true,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USER.COM",
                            NormalizedUserName = "USER@USER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBJTIn8N2pCwf6Ts9CoVtrNmgS8lxCria78IfsHBZnQwVTgwJL9VkiCzjPIieO1NJg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e6582cd-db3b-4bea-b69f-5acf0fe4d2db",
                            Sex = "Masculino",
                            TwoFactorEnabled = false,
                            UserName = "user@user.com"
                        },
                        new
                        {
                            Id = "1237ed08-6a44-4e20-8cf8-09ec5b3238cf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44d37776-1474-490a-82cc-45490ce189c0",
                            Date_Birth = new DateTime(2023, 6, 12, 18, 6, 23, 159, DateTimeKind.Local).AddTicks(8560),
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsEnabled = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJ9I3D0MRUEUhk9ajKsNYjlI2glYb/M2Nn63IEvEufFpNv568xkgDbI6j5BhX99W2g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "741eb14d-7d1c-4bc8-9206-e8593f80a96f",
                            Sex = "Masculino",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.EventUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("EventUsers");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.HouseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HouseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Apartamento"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Moradia, sem exterior"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Moradia, com exterior"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f2c49958-a598-4f84-9017-13025be9df0e",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5895f482-8ed1-4f32-aad8-f12689cebd27",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "29999d65-e585-47ff-b57d-69647ee65b54",
                            RoleId = "f2c49958-a598-4f84-9017-13025be9df0e"
                        },
                        new
                        {
                            UserId = "1237ed08-6a44-4e20-8cf8-09ec5b3238cf",
                            RoleId = "5895f482-8ed1-4f32-aad8-f12689cebd27"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Adoption", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.Animal", "Animal")
                        .WithMany("Adoptions")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACasotaBlazorServer.Data.AdoptionHouse", "House")
                        .WithMany("Adoptions")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", "User")
                        .WithMany("Adoptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("House");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.AdoptionHouse", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.HouseType", "Type")
                        .WithMany("Houses")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Animal", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", "User")
                        .WithMany("Animals")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Event", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.EventUser", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.Event", "Event")
                        .WithMany("EventUsers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", "User")
                        .WithMany("EventUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ACasotaBlazorServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.AdoptionHouse", b =>
                {
                    b.Navigation("Adoptions");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Animal", b =>
                {
                    b.Navigation("Adoptions");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.ApplicationUser", b =>
                {
                    b.Navigation("Adoptions");

                    b.Navigation("Animals");

                    b.Navigation("EventUsers");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.Event", b =>
                {
                    b.Navigation("EventUsers");
                });

            modelBuilder.Entity("ACasotaBlazorServer.Data.HouseType", b =>
                {
                    b.Navigation("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
