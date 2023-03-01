using Microsoft.EntityFrameworkCore;

namespace clothes_backend.Service.DalService
{
    public interface IUser
    {
        public Task<IEnumerable<UserModel>> GetUsersAsync();
    }
    public class UserRepo : IUser
    {

        private readonly Context db;

        public UserRepo(Context db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            var data = await (from c in db.Users
                              select new UserModel
                              {
                                  userName = c.UserName,
                                  firstName=c.firstName,
                                  lastName=c.lastName
                                  //password=c.
                              }).ToListAsync();
            //foreach (var i in data)
            //{
            //    var q = await (from p in db.products
            //                   where p.categoryID == i.id
            //                   select new ProductModel
            //                   {
            //                       id = p.id,
            //                       count = p.count,
            //                       image = p.image,
            //                       name = p.name,
            //                       price = p.price,
            //                       rate = p.rate,
            //                       title = p.title

            //                   }).ToListAsync();
            //    i.products = q;
            //}
            return data;
        }
    }
}
