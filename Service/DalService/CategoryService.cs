using clothes_backend.Entities.Dal;
using Microsoft.EntityFrameworkCore;

namespace clothes_backend.Service.DalService
{
    public interface ICategory
    {
        public Task<IEnumerable<CategoryModel>> GetCategoriesAsync();
    }
    public class CategoryRepo : ICategory
    {

        private readonly Context db;

        public CategoryRepo(Context db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
        {
            var data = await (from c in db.categories
                              select new CategoryModel
                              {
                                  id = c.id,
                                  name = c.name
                              }).ToListAsync();
            foreach(var i in data)
            {
                var q = await (from p in db.products
                               where p.categoryID == i.id
                               select new ProductModel
                               {
                                   id = p.id,
                                   count = p.count,
                                   image = p.image,
                                   name = p.name,
                                   price = p.price,
                                   rate = p.rate,
                                   title = p.title

                               }).ToListAsync();
                i.products = q;
            }
            return data;
        }
    }

}
