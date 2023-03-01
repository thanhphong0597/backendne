using clothes_backend.Entities.Cart;

namespace clothes_backend.Service.Client
{
    public interface IOrder
    {
        public Task<int> AddOrderAsync(OrderModel model);
    }
    public class OrderRepo : IOrder
    {
        protected readonly Context db;

        public OrderRepo(Context db)
        {
            this.db = db;
        }

        public async Task<int> AddOrderAsync(OrderModel model)
        {
            var neworder = new Order
            {
                firstName = model.firstName,
                lastName = model.lastName,
                address = model.address,
                phoneNumber = model.phoneNumber,
                color = model.color,
                size = model.size,
                number = model.number,
                product = model.product,
                status = Status.dangGiao,
                userId=model.user
            };
            var s = db.orders.Add(neworder);
            await db.SaveChangesAsync();
            return neworder.id;
        }
    }
}
