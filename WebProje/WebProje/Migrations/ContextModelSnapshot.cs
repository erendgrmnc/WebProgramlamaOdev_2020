﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProje.Models;

namespace WebProje.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebProje.Models.Abilities", b =>
                {
                    b.Property<int>("ABILITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABILITY_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ABILITY_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ABILITY_ID");

                    b.ToTable("ABILITY");
                });

            modelBuilder.Entity("WebProje.Models.Pokemon", b =>
                {
                    b.Property<int>("POKEMON_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("POKEMON_CATEGORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_HEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_IMG_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("POKEMON_PRICE")
                        .HasColumnType("int");

                    b.Property<string>("POKEMON_WEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("POKEMON_ID");

                    b.ToTable("POKEMON");
                });

            modelBuilder.Entity("WebProje.Models.PokemonAbility", b =>
                {
                    b.Property<int>("POKEMON_ABILITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ABILITY_ID")
                        .HasColumnType("int");

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_ABILITY_ID");

                    b.HasIndex("ABILITY_ID");

                    b.HasIndex("POKEMON_ID");

                    b.ToTable("POKEMON_ABILITY");
                });

            modelBuilder.Entity("WebProje.Models.PokemonStat", b =>
                {
                    b.Property<int>("POKEMON_STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("STAT_ID")
                        .HasColumnType("int");

                    b.Property<int>("STAT_VALUE")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_STAT_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("STAT_ID");

                    b.ToTable("POKEMON_STAT");
                });

            modelBuilder.Entity("WebProje.Models.PokemonType", b =>
                {
                    b.Property<int>("POKEMON_TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("TYPE_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_TYPE_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("TYPE_ID");

                    b.ToTable("POKEMON_TYPE");
                });

            modelBuilder.Entity("WebProje.Models.PokemonWeakness", b =>
                {
                    b.Property<int>("POKEMON_WEAKNESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("WEAKNESS_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_WEAKNESS_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("WEAKNESS_ID");

                    b.ToTable("POKEMON_WEAKNESS");
                });

            modelBuilder.Entity("WebProje.Models.Stat", b =>
                {
                    b.Property<int>("STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("STAT_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("STAT_ID");

                    b.ToTable("STAT");
                });

            modelBuilder.Entity("WebProje.Models.Type", b =>
                {
                    b.Property<int>("TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TYPE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TYPE_ID");

                    b.ToTable("TYPE");
                });

            modelBuilder.Entity("WebProje.Models.UserPokemon", b =>
                {
                    b.Property<int>("USER_POKEMON_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CREATION_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.HasKey("USER_POKEMON_ID");

                    b.HasIndex("Id");

                    b.HasIndex("POKEMON_ID");

                    b.ToTable("USER_POKEMON");
                });

            modelBuilder.Entity("WebProje.Models.UserWishlist", b =>
                {
                    b.Property<int>("USER_WISH_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CREATION_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.HasKey("USER_WISH_ID");

                    b.HasIndex("Id");

                    b.HasIndex("POKEMON_ID");

                    b.ToTable("USER_WISHLIST");
                });

            modelBuilder.Entity("WebProje.Models.Weakness", b =>
                {
                    b.Property<int>("WEAKNESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WEAKNESS_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WEAKNESS_ID");

                    b.ToTable("WEAKNESS");
                });

            modelBuilder.Entity("WebProje.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("USER_ABOUT")
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("USER_BALANCE")
                        .HasColumnType("int");

                    b.Property<DateTime>("USER_BIRTHDATE")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("User");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.PokemonAbility", b =>
                {
                    b.HasOne("WebProje.Models.Abilities", "Ability")
                        .WithMany("PokemonAbility")
                        .HasForeignKey("ABILITY_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonAbility")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.PokemonStat", b =>
                {
                    b.HasOne("WebProje.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonStat")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Stat", "Stat")
                        .WithMany("PokemonStat")
                        .HasForeignKey("STAT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.PokemonType", b =>
                {
                    b.HasOne("WebProje.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonType")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Type", "Type")
                        .WithMany("PokemonType")
                        .HasForeignKey("TYPE_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.PokemonWeakness", b =>
                {
                    b.HasOne("WebProje.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonWeakness")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Weakness", "Weakness")
                        .WithMany("PokemonWeakness")
                        .HasForeignKey("WEAKNESS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.UserPokemon", b =>
                {
                    b.HasOne("WebProje.Models.User", "User")
                        .WithMany("UserPokemon")
                        .HasForeignKey("Id");

                    b.HasOne("WebProje.Models.Pokemon", "Pokemon")
                        .WithMany("UserPokemon")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.UserWishlist", b =>
                {
                    b.HasOne("WebProje.Models.User", "User")
                        .WithMany("UserWishlist")
                        .HasForeignKey("Id");

                    b.HasOne("WebProje.Models.Pokemon", "Pokemon")
                        .WithMany("UserWishlist")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
