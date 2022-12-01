using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyBanHang.Data.Infrastructure
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private quanLyBanHangDbContext _dbContext;

        public UnitOfWork (IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
