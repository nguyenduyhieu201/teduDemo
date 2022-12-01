using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Model.Models;

namespace quanLyBanHang.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}