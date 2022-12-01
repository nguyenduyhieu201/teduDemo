using System;

namespace quanLyBanHang.Data
{
    public interface IDbFactory : IDisposable
    {
        quanLyBanHangDbContext Init();
    }
}
