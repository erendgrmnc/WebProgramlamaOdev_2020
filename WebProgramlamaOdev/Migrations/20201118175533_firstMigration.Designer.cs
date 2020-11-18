﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201118175533_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebProgramlamaOdev.Models.Abilities", b =>
                {
                    b.Property<int>("ABILITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ABILITY_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ABILITY_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PokemonAbilityPOKEMON_ABILITY_ID")
                        .HasColumnType("int");

                    b.HasKey("ABILITY_ID");

                    b.HasIndex("PokemonAbilityPOKEMON_ABILITY_ID");

                    b.ToTable("ABILITY");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Pokemon", b =>
                {
                    b.Property<int>("POKEMON_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("POKEMON_CATEGORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_HEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_IMG_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("POKEMON_PRICE")
                        .HasColumnType("int");

                    b.Property<string>("POKEMON_WEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PokemonAbilityPOKEMON_ABILITY_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PokemonStatPOKEMON_STAT_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PokemonTypePOKEMON_TYPE_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PokemonWeaknessPOKEMON_WEAKNESS_ID")
                        .HasColumnType("int");

                    b.Property<int?>("UserPokemonUSER_POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int?>("UserWishlistUSER_WISH_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_ID");

                    b.HasIndex("PokemonAbilityPOKEMON_ABILITY_ID");

                    b.HasIndex("PokemonStatPOKEMON_STAT_ID");

                    b.HasIndex("PokemonTypePOKEMON_TYPE_ID");

                    b.HasIndex("PokemonWeaknessPOKEMON_WEAKNESS_ID");

                    b.HasIndex("UserPokemonUSER_POKEMON_ID");

                    b.HasIndex("UserWishlistUSER_WISH_ID");

                    b.ToTable("POKEMON");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonAbility", b =>
                {
                    b.Property<int>("POKEMON_ABILITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("POKEMON_ABILITY_ID");

                    b.ToTable("POKEMON_ABILITY");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonStat", b =>
                {
                    b.Property<int>("POKEMON_STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("STAT_VALUE")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_STAT_ID");

                    b.ToTable("POKEMON_STAT");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonType", b =>
                {
                    b.Property<int>("POKEMON_TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("POKEMON_TYPE_ID");

                    b.ToTable("POKEMON_TYPE");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonWeakness", b =>
                {
                    b.Property<int>("POKEMON_WEAKNESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("POKEMON_WEAKNESS_ID");

                    b.ToTable("POKEMON_WEAKNESS");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Stat", b =>
                {
                    b.Property<int>("STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("PokemonStatPOKEMON_STAT_ID")
                        .HasColumnType("int");

                    b.Property<string>("STAT_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("STAT_ID");

                    b.HasIndex("PokemonStatPOKEMON_STAT_ID");

                    b.ToTable("STAT");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Type", b =>
                {
                    b.Property<int>("TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("PokemonTypePOKEMON_TYPE_ID")
                        .HasColumnType("int");

                    b.Property<string>("TYPE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TYPE_ID");

                    b.HasIndex("PokemonTypePOKEMON_TYPE_ID");

                    b.ToTable("TYPE");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.User", b =>
                {
                    b.Property<int>("USER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("USER_ABOUT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USER_BALANCE")
                        .HasColumnType("int");

                    b.Property<DateTime>("USER_BIRTHDATE")
                        .HasColumnType("datetime2");

                    b.Property<bool>("USER_ISADMIN")
                        .HasColumnType("bit");

                    b.Property<string>("USER_MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserPokemonUSER_POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int?>("UserWishlistUSER_WISH_ID")
                        .HasColumnType("int");

                    b.HasKey("USER_ID");

                    b.HasIndex("UserPokemonUSER_POKEMON_ID");

                    b.HasIndex("UserWishlistUSER_WISH_ID");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserPokemon", b =>
                {
                    b.Property<int>("USER_POKEMON_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATION_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("USER_POKEMON_ID");

                    b.ToTable("USER_POKEMON");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserWishlist", b =>
                {
                    b.Property<int>("USER_WISH_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATION_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("USER_WISH_ID");

                    b.ToTable("USER_WISHLIST");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Weakness", b =>
                {
                    b.Property<int>("WEAKNESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("PokemonWeaknessPOKEMON_WEAKNESS_ID")
                        .HasColumnType("int");

                    b.Property<string>("WEAKNESS_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WEAKNESS_ID");

                    b.HasIndex("PokemonWeaknessPOKEMON_WEAKNESS_ID");

                    b.ToTable("WEAKNESS");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Abilities", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.PokemonAbility", null)
                        .WithMany("ABILITY_ID")
                        .HasForeignKey("PokemonAbilityPOKEMON_ABILITY_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Pokemon", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.PokemonAbility", null)
                        .WithMany("POKEMON_ID")
                        .HasForeignKey("PokemonAbilityPOKEMON_ABILITY_ID");

                    b.HasOne("WebProgramlamaOdev.Models.PokemonStat", null)
                        .WithMany("POKEMON_ID")
                        .HasForeignKey("PokemonStatPOKEMON_STAT_ID");

                    b.HasOne("WebProgramlamaOdev.Models.PokemonType", null)
                        .WithMany("POKEMON_ID")
                        .HasForeignKey("PokemonTypePOKEMON_TYPE_ID");

                    b.HasOne("WebProgramlamaOdev.Models.PokemonWeakness", null)
                        .WithMany("POKEMON_ID")
                        .HasForeignKey("PokemonWeaknessPOKEMON_WEAKNESS_ID");

                    b.HasOne("WebProgramlamaOdev.Models.UserPokemon", null)
                        .WithMany("POKEMON_ID")
                        .HasForeignKey("UserPokemonUSER_POKEMON_ID");

                    b.HasOne("WebProgramlamaOdev.Models.UserWishlist", null)
                        .WithMany("POKEMON_ID")
                        .HasForeignKey("UserWishlistUSER_WISH_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Stat", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.PokemonStat", null)
                        .WithMany("STAT_ID")
                        .HasForeignKey("PokemonStatPOKEMON_STAT_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Type", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.PokemonType", null)
                        .WithMany("TYPE_ID")
                        .HasForeignKey("PokemonTypePOKEMON_TYPE_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.User", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.UserPokemon", null)
                        .WithMany("USER_ID")
                        .HasForeignKey("UserPokemonUSER_POKEMON_ID");

                    b.HasOne("WebProgramlamaOdev.Models.UserWishlist", null)
                        .WithMany("USER_ID")
                        .HasForeignKey("UserWishlistUSER_WISH_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Weakness", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.PokemonWeakness", null)
                        .WithMany("WEAKNESS_ID")
                        .HasForeignKey("PokemonWeaknessPOKEMON_WEAKNESS_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonAbility", b =>
                {
                    b.Navigation("ABILITY_ID");

                    b.Navigation("POKEMON_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonStat", b =>
                {
                    b.Navigation("POKEMON_ID");

                    b.Navigation("STAT_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonType", b =>
                {
                    b.Navigation("POKEMON_ID");

                    b.Navigation("TYPE_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonWeakness", b =>
                {
                    b.Navigation("POKEMON_ID");

                    b.Navigation("WEAKNESS_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserPokemon", b =>
                {
                    b.Navigation("POKEMON_ID");

                    b.Navigation("USER_ID");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserWishlist", b =>
                {
                    b.Navigation("POKEMON_ID");

                    b.Navigation("USER_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
