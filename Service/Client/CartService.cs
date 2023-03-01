using clothes_backend.Entities.Cart;
using clothes_backend.Entities.Client;
using Microsoft.EntityFrameworkCore;

namespace clothes_backend.Service.Client
{
    public interface ICart
    {
        public Task<int> AddCartAsync(ClientModel model);
        public Task<List<ClientModel>> AllCartAsync();

    }
    public class CartRepo : ICart
    {
        protected readonly Context db;
        public CartRepo(Context db)
        {
            this.db = db;
        }
        public async Task<int> AddCartAsync(ClientModel model)
        {
            //var newCart = new Cart
            //{
            //    firstName = model.firstName,
            //    lastName = model.lastName,
            //    address = model.address,
            //    phoneNumber = model.phoneNumber,
            //    color = model.color,
            //    size = model.size,
            //    number = model.number,
            //    product = model.product,
            //    status = Status.dangGiao
            //};
            //var s = db.carts.Add(newCart);
            //await db.SaveChangesAsync();
            //return newCart.id;
            int initId = (from a in db.clients
                                orderby a.id descending
                                select a.id).FirstOrDefault();
            int initIdCart = (from a in db.carts
                          orderby a.id descending
                          select a.id).FirstOrDefault();
            var newClient = new _Client
            {
                id= ++initId,
                firstName = model.firstName,
                lastName = model.lastName,
                address = model.address,
                phoneNumber = model.phoneNumber
            };

            var s = db.clients.Add(newClient);

            var initCart = model.cart_ProductModels;
            foreach (var cart in initCart)
            {
                var newCart = new _Cart
                {
                    id = ++initIdCart,
                    product = cart.product,
                    color = cart.color,
                    size = cart.size,
                    number = cart.number,
                    status = Status.dangGiao,
                    clientId = newClient.id
                };
                var d = db.carts.Add(newCart);
            }
            await db.SaveChangesAsync();
            return newClient.id;

        }

        public async Task<List<ClientModel>> AllCartAsync()
        {
            var clients =await (from c in db.clients
            select new ClientModel
            {
                id = c.id,
                firstName= c.firstName,
                lastName=c.lastName,
                address=c.address,
                phoneNumber=c.phoneNumber
            }).ToListAsync();
            foreach (var client in clients)
            {
                var cart = await (from c in db.carts
                                  where client.id == c.clientId
                                  select new Cart_productModel
                                  {
                                      color = c.color,
                                      number = c.number,
                                      product = c.product,
                                      size = c.size
                                  }).ToListAsync();
                client.cart_ProductModels = cart;
            }
            return clients;
        }
    }
}
