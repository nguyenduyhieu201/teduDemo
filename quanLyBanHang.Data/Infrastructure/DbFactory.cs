using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyBanHang.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
        quanLyBanHangDbContext dbContext;
        public quanLyBanHangDbContext Init()
        {
            return dbContext ?? (dbContext = new quanLyBanHangDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
