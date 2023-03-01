using clothes_backend.Entities.Cart;
using clothes_backend.Entities.Client;
using clothes_backend.Entities.Dal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clothes_backend.Service
{
    public class CategoryModel
    {
        public int id { get; set; }
        public string name { get; set; }

        public IEnumerable<ProductModel> products { get; set; }

    }
    public class ProductModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public string title { get; set; }

        public double price { get; set; }

        public double rate { get; set; }

        public int count { get; set; }

        public string? image { get; set; }
        public string? category { get; set; }

        public IEnumerable<StockModel>? stocks { get; set; }

    }
    
    public class ProductNameModel{
        public int id {get;set;}
        public string name {get;set;}
        public double price {get;set;}
    }
    public class ProductStockModel{
        public int id {get;set;}
        public string color {get;set;}
        public double size {get;set;}
        public int number {get;set;}
    }
    public class ProductAddModel
    {

        public string name { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public int categoryID { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }

    }
    public class StockModel
    {
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
    }
    public class AddStockModel
    {
        public int id { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
    }
    public class ClientModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        //public string product { get; set; }
        //public string? color { get; set; }
        //public double size { get; set; }
        //public double number { get; set; }
        //public Status status { get; set; }
        public List<Cart_productModel> cart_ProductModels { get; set; }
    }

    public class Cart_productModel
    {
        public string product { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
    }
    public class AllCartModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string product { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
        public Status status { get; set; }
    }
    public class OrderModel
    {

        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string address { get; set; }
        public string? phoneNumber { get; set; }
        public string? product { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
        public Status status { get; set; }
        public string user { get; set; }
    }
    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        public string? firstName { get; set; }
        public string? lastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }

    public class UserModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }    
    }
        public class Response
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }

   
}
