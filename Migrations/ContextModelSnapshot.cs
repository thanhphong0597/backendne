﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using clothes_backend.Service;

#nullable disable

namespace clothesbackend.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("clothes_backend.Entities.Cart.Order", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("number")
                        .HasColumnType("float");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("size")
                        .HasColumnType("float");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("clothes_backend.Entities.Cart._Cart", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("clientId")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("number")
                        .HasColumnType("float");

                    b.Property<string>("product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("size")
                        .HasColumnType("float");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clientId");

                    b.ToTable("carts");

                    b.HasData(
                        new
                        {
                            id = 4,
                            clientId = 1,
                            color = "red",
                            number = 1.0,
                            product = "Mens Cotton Jacket ",
                            size = 38.0,
                            status = 0
                        },
                        new
                        {
                            id = 2,
                            clientId = 1,
                            color = "green",
                            number = 1.0,
                            product = "Mens Cotton Jacket ",
                            size = 40.0,
                            status = 0
                        },
                        new
                        {
                            id = 3,
                            clientId = 2,
                            color = "red",
                            number = 1.0,
                            product = "Mens Cotton Jacket ",
                            size = 38.0,
                            status = 0
                        });
                });

            modelBuilder.Entity("clothes_backend.Entities.Client.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("clothes_backend.Entities.Client._Client", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("clients");

                    b.HasData(
                        new
                        {
                            id = 1,
                            address = "nha1",
                            firstName = "truong",
                            lastName = "minh nguyen",
                            phoneNumber = "123456666"
                        },
                        new
                        {
                            id = 2,
                            address = "nha2",
                            firstName = "henry",
                            lastName = "Lord",
                            phoneNumber = "222333111"
                        },
                        new
                        {
                            id = 3,
                            address = "nha3",
                            firstName = "Anatamo",
                            lastName = "Daisuki",
                            phoneNumber = "3331112222"
                        });
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Attri", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("number")
                        .HasColumnType("float");

                    b.Property<double>("size")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("attries");

                    b.HasData(
                        new
                        {
                            id = 1,
                            color = "red",
                            number = 2.0,
                            size = 38.0
                        },
                        new
                        {
                            id = 2,
                            color = "green",
                            number = 3.0,
                            size = 40.0
                        },
                        new
                        {
                            id = 6,
                            color = "red",
                            number = 5.0,
                            size = 40.0
                        },
                        new
                        {
                            id = 3,
                            color = "red",
                            number = 1.0,
                            size = 39.0
                        },
                        new
                        {
                            id = 4,
                            color = "red",
                            number = 2.0,
                            size = 41.0
                        },
                        new
                        {
                            id = 5,
                            color = "yellow",
                            number = 2.0,
                            size = 0.0
                        });
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Men's Clothing"
                        },
                        new
                        {
                            id = 2,
                            name = "Women's Clothing"
                        },
                        new
                        {
                            id = 3,
                            name = "Jewelery"
                        });
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Product", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            categoryID = 1,
                            count = 0,
                            name = "Mens Casual Premium Slim Fit T - Shirts",
                            price = 33.399999999999999,
                            rate = 0.0,
                            title = "Men"
                        },
                        new
                        {
                            id = 2,
                            categoryID = 1,
                            count = 0,
                            name = "Mens Cotton Jacket ",
                            price = 12.4,
                            rate = 0.0,
                            title = "Men"
                        },
                        new
                        {
                            id = 3,
                            categoryID = 2,
                            count = 0,
                            name = "Ao nu 1",
                            price = 33.399999999999999,
                            rate = 0.0,
                            title = "Women"
                        },
                        new
                        {
                            id = 4,
                            categoryID = 3,
                            count = 0,
                            name = "Vong Vang nay no a",
                            price = 33.399999999999999,
                            rate = 0.0,
                            title = "Jewelery"
                        },
                        new
                        {
                            id = 5,
                            categoryID = 2,
                            count = 0,
                            name = "Ao nike Nam",
                            price = 50.0,
                            rate = 0.0,
                            title = "Men"
                        },
                        new
                        {
                            id = 6,
                            categoryID = 2,
                            count = 0,
                            name = "Ao somi nu",
                            price = 33.399999999999999,
                            rate = 0.0,
                            title = "Women"
                        },
                        new
                        {
                            id = 7,
                            categoryID = 3,
                            count = 0,
                            name = "Váy ngắn dạ hội",
                            price = 60.0,
                            rate = 0.0,
                            title = "Women"
                        },
                        new
                        {
                            id = 8,
                            categoryID = 3,
                            count = 0,
                            name = "Bông tai hoa cương",
                            price = 1000.0,
                            rate = 0.0,
                            title = "Jewelery"
                        },
                        new
                        {
                            id = 9,
                            categoryID = 3,
                            count = 0,
                            name = "Bông tai không hoa cương",
                            price = 1.0,
                            rate = 0.0,
                            title = "Jewelery"
                        },
                        new
                        {
                            id = 10,
                            categoryID = 2,
                            count = 0,
                            name = "Váy dài qua đầu gối",
                            price = 30.0,
                            rate = 0.0,
                            title = "Women"
                        },
                        new
                        {
                            id = 11,
                            categoryID = 1,
                            count = 0,
                            name = "Quần tây thanh lịch",
                            price = 41.0,
                            rate = 0.0,
                            title = "Men"
                        },
                        new
                        {
                            id = 12,
                            categoryID = 1,
                            count = 0,
                            name = "Quần tây không thanh lịch cho lắm",
                            price = 4.0,
                            rate = 0.0,
                            title = "Men"
                        },
                        new
                        {
                            id = 13,
                            categoryID = 3,
                            count = 0,
                            name = "Vòng cổ chân châu chân thực",
                            price = 33.0,
                            rate = 0.0,
                            title = "Jewelery"
                        },
                        new
                        {
                            id = 14,
                            categoryID = 3,
                            count = 0,
                            name = "Khuyên tai che mặt",
                            price = 33.0,
                            rate = 0.0,
                            title = "Jewelery"
                        },
                        new
                        {
                            id = 15,
                            categoryID = 3,
                            count = 0,
                            name = "Áo ngủ cho nữ",
                            price = 33.399999999999999,
                            rate = 0.0,
                            title = "Women"
                        },
                        new
                        {
                            id = 16,
                            categoryID = 1,
                            count = 0,
                            name = "Áo ngủ cho Nam",
                            price = 33.0,
                            rate = 0.0,
                            title = "Men"
                        },
                        new
                        {
                            id = 17,
                            categoryID = 3,
                            count = 0,
                            name = "Vòng hoa may mắn",
                            price = 500.0,
                            rate = 0.0,
                            title = "Jewelery"
                        },
                        new
                        {
                            id = 18,
                            categoryID = 3,
                            count = 0,
                            name = "Vàng mã",
                            price = 4.0,
                            rate = 0.0,
                            title = "Jewelery"
                        });
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Stock", b =>
                {
                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.Property<int>("attriID")
                        .HasColumnType("int");

                    b.HasKey("productID", "attriID");

                    b.HasIndex("attriID");

                    b.ToTable("Stock", (string)null);

                    b.HasData(
                        new
                        {
                            productID = 1,
                            attriID = 1
                        },
                        new
                        {
                            productID = 1,
                            attriID = 2
                        },
                        new
                        {
                            productID = 1,
                            attriID = 6
                        },
                        new
                        {
                            productID = 2,
                            attriID = 3
                        },
                        new
                        {
                            productID = 3,
                            attriID = 4
                        },
                        new
                        {
                            productID = 4,
                            attriID = 5
                        });
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
                    b.HasOne("clothes_backend.Entities.Client.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("clothes_backend.Entities.Client.User", null)
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

                    b.HasOne("clothes_backend.Entities.Client.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("clothes_backend.Entities.Client.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("clothes_backend.Entities.Cart.Order", b =>
                {
                    b.HasOne("clothes_backend.Entities.Client.User", "user")
                        .WithMany("Orders")
                        .HasForeignKey("userId");

                    b.Navigation("user");
                });

            modelBuilder.Entity("clothes_backend.Entities.Cart._Cart", b =>
                {
                    b.HasOne("clothes_backend.Entities.Client._Client", "client")
                        .WithMany("carts")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Product", b =>
                {
                    b.HasOne("clothes_backend.Entities.Dal.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Stock", b =>
                {
                    b.HasOne("clothes_backend.Entities.Dal.Attri", "attri")
                        .WithMany("stocks")
                        .HasForeignKey("attriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clothes_backend.Entities.Dal.Product", "product")
                        .WithMany("stocks")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("attri");

                    b.Navigation("product");
                });

            modelBuilder.Entity("clothes_backend.Entities.Client.User", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("clothes_backend.Entities.Client._Client", b =>
                {
                    b.Navigation("carts");
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Attri", b =>
                {
                    b.Navigation("stocks");
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("clothes_backend.Entities.Dal.Product", b =>
                {
                    b.Navigation("stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
