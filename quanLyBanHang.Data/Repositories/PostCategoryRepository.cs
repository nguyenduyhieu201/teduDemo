using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Model.Models;

namespace quanLyBanHang.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}