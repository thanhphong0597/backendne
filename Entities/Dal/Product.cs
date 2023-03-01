using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clothes_backend.Entities.Dal
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        
        public string name { get; set; }

        public string title { get; set; }

        public double price { get; set; }    

        public double rate { get; set; }

        public int count { get; set; }

        public string? image { get; set; }


        //foreign key
        //category
        [ForeignKey("category")]
        public int categoryID { get; set; }

        public Category? category { get; set; }

        //stock
        public List<Stock>? stocks { get; set; }
    }
}
