using System.Collections.Generic;
using System.Linq;
using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Model.Models;

namespace quanLyBanHang.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IQueryable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IQueryable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}