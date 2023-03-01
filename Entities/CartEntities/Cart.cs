using clothes_backend.Entities.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clothes_backend.Entities.Cart
{
    public enum Status
    {
        dangGiao, daNhan, Huy
    }
    public class _Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string product { get; set; }
        public string? color { get; set; }
        public double size { get; set; }
        public double number { get; set; }
        public Status status {get;set;} 

        public _Client? client { get; set; }
        [ForeignKey("client")]
        public int clientId { get; set; }
    }
}
