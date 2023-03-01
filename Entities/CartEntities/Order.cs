using clothes_backend.Entities.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clothes_backend.Entities.Cart
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string address { get; set; }
        public string? phoneNumber { get; set; }
        public string? product { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
        public Status status { get; set; }

        public User? user { get; set; }
        [ForeignKey("user")]
        public string? userId { get; set; }

    }
}
