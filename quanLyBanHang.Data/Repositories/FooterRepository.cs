using quanLyBanHang.Data;
using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Model.Models;


namespace quanLyBanHang.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}