﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Tech_Trader_Server.Migrations
{
    [DbContext(typeof(TechTraderDbContext))]
    [Migration("20241119023426_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TechTrader.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Desktops"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monitors"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gaming Consoles"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PC Parts"
                        },
                        new
                        {
                            Id = 6,
                            Name = "PC Accessories"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Gaming Console Accessories"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Movies"
                        },
                        new
                        {
                            Id = 10,
                            Name = "TV Shows"
                        });
                });

            modelBuilder.Entity("TechTrader.Models.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Conditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Used"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Open-Box"
                        });
                });

            modelBuilder.Entity("TechTrader.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ConditionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<bool>("Sold")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ConditionId");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            ConditionId = 1,
                            CreatedOn = new DateTime(2024, 11, 15, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Brand new MacBook Pro with M1 chip, 16GB RAM, and 1TB SSD.",
                            ImageUrl = "https://example.com/images/macbook.jpg",
                            Name = "MacBook Pro 16-inch",
                            Price = 2200.00m,
                            SellerId = 1,
                            Sold = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 5,
                            ConditionId = 2,
                            CreatedOn = new DateTime(2024, 11, 14, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lightly used RTX 3080 graphics card, excellent condition.",
                            ImageUrl = "https://example.com/images/rtx3080.jpg",
                            Name = "NVIDIA RTX 3080 GPU",
                            Price = 650.00m,
                            SellerId = 2,
                            Sold = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 8,
                            ConditionId = 3,
                            CreatedOn = new DateTime(2024, 11, 12, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            Description = "Open-box PS5 game, no scratches on the disc.",
                            ImageUrl = "https://example.com/images/cod-mw2.jpg",
                            Name = "Call of Duty: Modern Warfare II",
                            Price = 40.00m,
                            SellerId = 3,
                            Sold = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 6,
                            ConditionId = 1,
                            CreatedOn = new DateTime(2024, 11, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New mechanical keyboard with RGB lighting.",
                            ImageUrl = "https://example.com/images/keyboard.jpg",
                            Name = "Razer BlackWidow Keyboard",
                            Price = 120.00m,
                            SellerId = 2,
                            Sold = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            ConditionId = 2,
                            CreatedOn = new DateTime(2024, 11, 8, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Description = "Used PS5 in great condition, comes with one controller.",
                            ImageUrl = "https://example.com/images/ps5.jpg",
                            Name = "PlayStation 5 Console",
                            Price = 450.00m,
                            SellerId = 1,
                            Sold = false
                        });
                });

            modelBuilder.Entity("TechTrader.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Hi, is this item still available?",
                            SellerId = 1,
                            SentAt = new DateTime(2024, 11, 18, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            Content = "Yes, it's available. Would you like to arrange a pickup?",
                            SellerId = 2,
                            SentAt = new DateTime(2024, 11, 18, 10, 35, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Can you provide more details about the condition?",
                            SellerId = 1,
                            SentAt = new DateTime(2024, 11, 18, 11, 15, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "When are you available to meet?",
                            SellerId = 3,
                            SentAt = new DateTime(2024, 11, 18, 12, 45, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "I'm interested. Is the price negotiable?",
                            SellerId = 3,
                            SentAt = new DateTime(2024, 11, 18, 13, 10, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TechTrader.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cash",
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Venmo",
                            UserId = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "PayPal",
                            UserId = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Apple Pay",
                            UserId = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cash App",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("TechTrader.Models.SavedListing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ListingId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.ToTable("SavedListings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ListingId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            ListingId = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            ListingId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            ListingId = 5,
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            ListingId = 4,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("TechTrader.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsSeller")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "San Francisco",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            ImageUrl = "https://example.com/images/alice.jpg",
                            IsSeller = true,
                            LastName = "Johnson",
                            State = "CA",
                            Uid = "PzXnYW3LbJkfVT92QLrCoM87F15N4",
                            Zip = "94103"
                        },
                        new
                        {
                            Id = 2,
                            City = "Austin",
                            Email = "bob.smith@example.com",
                            FirstName = "Bob",
                            ImageUrl = "https://example.com/images/bob.jpg",
                            IsSeller = true,
                            LastName = "Smith",
                            State = "TX",
                            Uid = "ZpkMvJ2YWbxELQ39VTfXrK8C76M4",
                            Zip = "73301"
                        },
                        new
                        {
                            Id = 3,
                            City = "Seattle",
                            Email = "cathy.lee@example.com",
                            FirstName = "Cathy",
                            ImageUrl = "https://example.com/images/cathy.jpg",
                            IsSeller = true,
                            LastName = "Lee",
                            State = "WA",
                            Uid = "QlmPnKY2WvcrLJ37TZfXoC8F65N9",
                            Zip = "98101"
                        });
                });

            modelBuilder.Entity("TechTrader.Models.Listing", b =>
                {
                    b.HasOne("TechTrader.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechTrader.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Condition");
                });

            modelBuilder.Entity("TechTrader.Models.SavedListing", b =>
                {
                    b.HasOne("TechTrader.Models.Listing", "Listing")
                        .WithMany()
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });
#pragma warning restore 612, 618
        }
    }
}
