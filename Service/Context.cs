using clothes_backend.Entities.Cart;
using clothes_backend.Entities.Client;
using clothes_backend.Entities.Dal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace clothes_backend.Service
{
    public class Context : IdentityDbContext<User>
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Attri> attries { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<_Cart> carts { get; set; }
        public DbSet<_Client> clients { get; set; }

        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public Context(DbContextOptions options) : base(options)
        {
        }
       
        protected override async void OnModelCreating(ModelBuilder b)
        {

            base.OnModelCreating(b);
            b.ApplyConfiguration(new StockConfig());
            b.Initial();
      
           
            

        }

    }
    public static class Dulieumau
    {
        public static void Initial (this ModelBuilder b)
        {
            b.Entity<Category>().HasData(
                new Category { id = 1, name = "Men's Clothing" },
                new Category { id = 2, name = "Women's Clothing" },
                new Category { id = 3, name = "Jewelery" },
                new Category { id =4, name = "chan vay" }

            );
            

            b.Entity<Product>().HasData(
                new Product { 
                    id=1, 
                    name= "Mens Casual Premium Slim Fit T - Shirts",
                    price=33.4,
                    title="Men",
                    categoryID=3
                },
                new Product
                {
                    id = 2,
                    name = "Mens Cotton Jacket ",
                    price = 12.4,
                    title = "Men",
                    categoryID=1
                },
                new Product
                {
                    id = 3,
                    name = "Ao nu 1",
                    price = 33.4,
                    title = "Women",
                    categoryID=2
                },
                new Product
                {
                    id = 4,
                    name = "Vong Vang nay no a",
                    price = 33.4,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 5,
                    name = "Ao nike Nam",
                    price = 50,
                    title = "Men",
                    categoryID = 2

                },
                new Product
                {
                    id = 6,
                    name = "Ao somi nu",
                    price = 33.4,
                    title = "Women",
                    categoryID = 2

                },
                new Product
                {
                    id = 7,
                    name = "Váy ngắn dạ hội",
                    price = 60,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 8,
                    name = "Bông tai hoa cương",
                    price = 1000,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 9,
                    name = "Bông tai không hoa cương",
                    price = 1,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 10,
                    name = "Váy dài qua đầu gối",
                    price = 30,
                    title = "Women",
                    categoryID = 2

                },
                new Product
                {
                    id = 11,
                    name = "Quần tây thanh lịch",
                    price = 41,
                    title = "Men",
                    categoryID = 1

                },
                new Product
                {
                    id = 12,
                    name = "Quần tây không thanh lịch cho lắm",
                    price = 4,
                    title = "Men",
                    categoryID = 1

                },
                new Product
                {
                    id = 13,
                    name = "Vòng cổ chân châu chân thực",
                    price = 33,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 14,
                    name = "Khuyên tai che mặt",
                    price = 33,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 15,
                    name = "Áo ngủ cho nữ",
                    price = 33.4,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 16,
                    name = "Áo ngủ cho Nam",
                    price = 33,
                    title = "Men",
                    categoryID = 1

                },
                new Product
                {
                    id = 17,
                    name = "Vòng hoa may mắn",
                    price = 500,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 18,
                    name = "Vàng mã",
                    price = 4,
                    title = "Jewelery",
                    categoryID = 3

                }
                );

            b.Entity<Attri>().HasData(
                new Attri { id=1,color="red",number=2,size=38},
                new Attri { id = 2, color = "green", number = 3, size = 40 },
                new Attri { id = 6, color = "red", number = 5, size = 40 },
                new Attri { id = 3, color = "red", number = 1, size = 39 },
                new Attri { id = 4, color = "red", number = 2, size = 41 },
                new Attri { id = 5, color = "yellow", number = 2 }
                );
            b.Entity<Stock>().HasData(
                new Stock { productID=1,attriID=1},
                new Stock { productID = 1, attriID = 2 },
                new Stock { productID=1, attriID=6},
                new Stock { productID = 2, attriID = 3 },
                new Stock { productID = 3, attriID = 4 },
                new Stock { productID = 4, attriID = 5 }
                );
            b.Entity<_Client>().HasData(
                new _Client { id = 1, address = "nha1", firstName = "truong", lastName = "minh nguyen", phoneNumber = "123456666" },
                new _Client { id = 2, address = "nha2", firstName = "henry", lastName = "Lord", phoneNumber = "222333111" },
                new _Client { id = 3, address = "nha3", firstName = "Anatamo", lastName = "Daisuki", phoneNumber = "3331112222" }

                );
            b.Entity<_Cart>().HasData(
                new _Cart { id=4,clientId=1,color="red",product= "Mens Cotton Jacket ",size=38,number=1 },
                new _Cart { id=2,clientId=1,color="green",product= "Mens Cotton Jacket ",size=40,number=1 },
                new _Cart { id=3,clientId=2,color="red",product= "Mens Cotton Jacket ",size=38,number=1 }
                );
        }
    }
}
