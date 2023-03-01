using clothes_backend.Entities.Dal;
using Microsoft.EntityFrameworkCore;

namespace clothes_backend.Service.DalService
{
    public interface IStock
    {
        public Task<int> AddStockAsync(AddStockModel model);
        public Task<int> DeleteStockAsync(AddStockModel model);
    }
    public class StockRepo : IStock
    {

        private readonly Context db;

        public StockRepo(Context db)
        {
            this.db = db;
        }

        public async Task<int> AddStockAsync(AddStockModel model)
        {
            var initId = (from a in db.attries
                          orderby a.id descending
                          select a.id).FirstOrDefault();
            var newattri = new Attri
            {
                color = model.color,
                size = model.size,
                number = model.number,
                id = ++initId
            };
            db.attries.Add(newattri);
            await db.AddRangeAsync();
            var ns = new Stock
            {
                attriID = newattri.id,
                productID = model.id
            };
            db.stocks.Add(ns);
            await db.SaveChangesAsync();
            return initId;
        }

        public async Task<int> DeleteStockAsync(AddStockModel model)
        {
            var st = await (from s in db.stocks
                            join a in db.attries on s.attriID equals a.id
                            where s.productID == model.id
                            select a
                           ).ToListAsync();
            foreach(var item in st)
            {
                if (item.color == model.color && item.size == model.size)
                {
                    db.stocks.RemoveRange(await (from s in db.stocks where s.attriID == item.id select s).ToListAsync());
                    db.attries.Remove(item);
                }
                
            }
            await db.SaveChangesAsync();
            return model.id;
        }
    }

}
