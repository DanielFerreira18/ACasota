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
    [Migration("20230614184217_BugFix_NewUser_PartnerUsernameChange")]
    partial class BugFix_NewUser_PartnerUsernameChange
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
                            Id = "25a3eff2-e19e-4193-b942-1f310ac748a1",
                            Age = "Baby",
                            IsSterile = false,
                            IsVacinated = false,
                            Name = "Lucas",
                            Race = "Cat",
                            Sex = "Male",
                            Size = "Little",
                            UserId = "bcf2c623-f098-40c8-b3b9-75b36f6cf613"
                        },
                        new
                        {
                            Id = "d46eb452-dcae-4fd4-8e3e-e87928d73f83",
                            Age = "Junior",
                            IsSterile = false,
                            IsVacinated = false,
                            Name = "Mino",
                            Race = "Cat",
                            Sex = "Male",
                            Size = "Little"
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
                            Id = "bcf2c623-f098-40c8-b3b9-75b36f6cf613",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e720c394-1ff8-47bf-a72d-d5da1d9aced2",
                            Date_Birth = new DateTime(2023, 6, 14, 19, 42, 16, 505, DateTimeKind.Local).AddTicks(1844),
                            Email = "user@user.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            IsEnabled = true,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USER.COM",
                            NormalizedUserName = "USER@USER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECymn8N5HpSCrAItYILCpTfKiGgj3m12pKtuHdT6V5d9Tw2+R/m5RLn2c7S+CSgtNQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "10e834af-436a-4c17-a226-32a1df890b7c",
                            Sex = "Masculino",
                            TwoFactorEnabled = false,
                            UserName = "user@user.com"
                        },
                        new
                        {
                            Id = "b7084a3c-c594-440f-8f53-70d1dd11c4a0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "946e138f-7455-4cfe-9ffa-59829693d60b",
                            Date_Birth = new DateTime(2023, 6, 14, 19, 42, 16, 615, DateTimeKind.Local).AddTicks(5800),
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsEnabled = true,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELTGPq8VxxXQCKJEKPR1IMbkvPs4YKasWz7w6Chr2kFWkklXXLN8ifCBrXIX/Xtt0g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "956e452c-81fb-4857-97d6-4b8912c5012d",
                            Sex = "Masculino",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "482d381d-deef-43ee-8c32-1131d508468c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "59886b4f-b1db-4173-841b-b6ffa38e8300",
                            Date_Birth = new DateTime(2023, 6, 14, 19, 42, 16, 716, DateTimeKind.Local).AddTicks(8353),
                            Email = "partner@partner.com",
                            EmailConfirmed = false,
                            FirstName = "Partner",
                            IsEnabled = true,
                            LastName = "Partner",
                            LockoutEnabled = false,
                            NormalizedEmail = "PARTNER@PARTNER.COM",
                            NormalizedUserName = "PARTNER@PARTNER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEH4sqre2TcoWHpqdPa2rGtGZ/dYzcy4/AkwTZci0j1WzVK+VTgJicaPxbX8d+zdYpg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e5ce30e4-e6f4-498a-b8e1-8b47f32dd490",
                            Sex = "Feminino",
                            TwoFactorEnabled = false,
                            UserName = "partner@partner.com"
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

                    b.HasKey("Id");

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
                            Id = "d58ed447-9716-4244-a09f-bd45c45c3cbd",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "40ca0164-ab60-420c-aa36-47a2a5cd4bf9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "12c79e2e-3b3f-4010-862f-20fd287c3deb",
                            Name = "Partner",
                            NormalizedName = "PARTNER"
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
                            UserId = "bcf2c623-f098-40c8-b3b9-75b36f6cf613",
                            RoleId = "d58ed447-9716-4244-a09f-bd45c45c3cbd"
                        },
                        new
                        {
                            UserId = "b7084a3c-c594-440f-8f53-70d1dd11c4a0",
                            RoleId = "40ca0164-ab60-420c-aa36-47a2a5cd4bf9"
                        },
                        new
                        {
                            UserId = "482d381d-deef-43ee-8c32-1131d508468c",
                            RoleId = "12c79e2e-3b3f-4010-862f-20fd287c3deb"
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
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

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