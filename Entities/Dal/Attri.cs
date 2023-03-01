using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace clothes_backend.Entities.Dal
{
    public class Attri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }

        //foreign key
        //stock
        public List<Stock>? stocks { get; set; }
    }
}
