using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Model.Models;

namespace quanLyBanHang.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}