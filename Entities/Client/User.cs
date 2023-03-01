using clothes_backend.Entities.Cart;
using Microsoft.AspNetCore.Identity;

namespace clothes_backend.Entities.Client
{
    public class User : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
