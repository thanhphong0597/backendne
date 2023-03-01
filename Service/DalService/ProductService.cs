using clothes_backend.Entities.Dal;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace clothes_backend.Service.DalService
{

    public interface IProduct
    {
        public Task<IEnumerable<ProductModel>> GetProductsAsync();
        public Task<ProductModel> GetProductAsync(int id);
        public Task<int> EditProductAsync(ProductModel model);
        public Task<int> EditProductNameAsync(ProductNameModel model);
        public Task<int> EditProductStockAsync(ProductStockModel model);
        public Task<int> AddProductAsync(ProductAddModel model);
        public Task<int> DeleteProductAsync(int id);
    }

    public class ProductRepo : IProduct
    {
        private readonly Context db;

        public ProductRepo(Context db)
        {
            this.db = db;
        }

        public async Task<int> AddProductAsync(ProductAddModel model)
        {
            int initIdPro = (from a in db.products
                              orderby a.id descending
                              select a.id).FirstOrDefault();
            int initIdAttri = (from a in db.attries
                             orderby a.id descending
                             select a.id).FirstOrDefault();
            var newAttri = new Attri
            {
                id = ++initIdAttri,
                color = model.color,
                number = model.number,
                size = model.size,
            };

            var newProduct = new Product
            {
                id = ++initIdPro,
                categoryID = model.categoryID,
                count = 0,
                image = " ",
                name = model.name,
                rate = 5,
                price = model.price,
                title = model.title,

            };
            var s = new Stock
            {
                attriID = newAttri.id,
                productID = newProduct.id,
            };
            db.attries.Add(newAttri);
            await db.SaveChangesAsync();
            db.products.Add(newProduct);
            await db.SaveChangesAsync();
            db.stocks.Add(s);
            await db.SaveChangesAsync();
            return newProduct.id;

        }

        public async Task<int> DeleteProductAsync(int id)
        {
            var stocks = await (from s in db.stocks
                                where s.productID == id
                                select s).ToListAsync();

            if (stocks != null && stocks.Any())
            {
                foreach (var stock in stocks)
                {
                    db.stocks.Remove(stock);
                }

                await db.SaveChangesAsync();
            }

            db.products.Remove(await (from p in db.products where p.id == id select p).FirstOrDefaultAsync());
            await db.SaveChangesAsync();
            return id;
        }

        public async Task<int> EditProductAsync(ProductModel model)
        {
            var p = await db.products!.FindAsync(model.id);
            if (p != null)
            {
                p.price = model.price;
                p.title = model.title;
                p.name = model.name;
                p.count = model.count;
            }
            //p gan cac gia tri de lam nhu ten, gia, ...
            var q = await (from a in db.attries
                           join s in db.stocks on a.id equals s.attriID
                           where s.productID == p.id
                           select a
                           ).ToListAsync();
            //q: tra ve cac attries bao gom id, size, color, num ...
            var st = model.stocks.ToList();
            foreach (var item in q)
            {
                foreach (var item2 in st)
                {
                    if (item.color == item2.color && item.size == item2.size)
                    {
                        item.number = item2.number;
                    }
                }
                db.attries.Update(item);


            }
            //foreach (var sdf in model.stocks)
            //{
            //    if (item.color == st.color && item.size == st.size)
            //    {
            //        item.number = st.number;
            //    }
            //}
            db.products.Update(p);
            await db.SaveChangesAsync();
            return 0;
        }

        public async Task<int> EditProductNameAsync(ProductNameModel model)
        {
            var p = await db.products!.FindAsync(model.id);
            if (p != null)
            {
                p.price = model.price;
                p.name = model.name;
            }
            db.products.Update(p);
            await db.SaveChangesAsync();
            //p gan cac gia tri de lam nhu ten, gia, ...
            return model.id;

        }

        public async Task<int> EditProductStockAsync(ProductStockModel model)
        {
            var p = await (from a in db.attries
                           join s in db.stocks on a.id equals s.attriID
                           where s.productID == model.id
                           select a
                           ).ToListAsync();
            foreach (var item in p)
            {
                if (item.color == model.color && item.size == model.size)
                {
                    item.number = model.number;
                    db.attries.Update(item);
                }
            }
            db.SaveChanges();
            return model.id;

        }

        public async Task<ProductModel> GetProductAsync(int id)
        {
            var result = await db.products!.FindAsync(id);

            var q = await (from a in db.attries
                           join s in db.stocks on a.id equals s.attriID
                           where s.productID == result.id
                           select new StockModel
                           {
                               color = a.color,
                               number = a.number,
                               size = a.size
                           }).ToListAsync();
            var data = new ProductModel
            {
                id = result.id,
                count = result.count,
                image = result.image,
                name = result.name,
                price = result.price,
                rate = result.rate,
                title = result.title,
                stocks = q
            };
            return data;
        }

        public async Task<IEnumerable<ProductModel>> GetProductsAsync()
        {
            var data = await (from p in db.products
                              join c in db.categories on p.categoryID equals c.id
                              select new ProductModel
                              {
                                  id = p.id,
                                  count = p.count,
                                  image = p.image,
                                  name = p.name,
                                  price = p.price,
                                  rate = p.rate,
                                  title = p.title,
                                  category = c.name
                              }).ToListAsync();
            return data;
        }


    }
}
