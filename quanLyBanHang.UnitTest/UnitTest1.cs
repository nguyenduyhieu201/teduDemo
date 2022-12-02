//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using quanLyBanHang.Data;
using quanLyBanHang.Data.Repositories;

namespace quanLyBanHang.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        private IDbFactory _dbFactory;
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        [SetUp]
        public void SetUp(IDbFactory dbFactory, 
            IPostCategoryRepository postCategoryRepository,
            IUnitOfWork unitOfWork
            )
        {
            _dbFactory = dbFactory;
            _postCategoryRepository = postCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        [Test]
        public void Post_Category_GetAll()
        {
            var list = _postCategoryRepository.GetAll();
            Assert.Equals(3, list.Count);
        }


    }
}
