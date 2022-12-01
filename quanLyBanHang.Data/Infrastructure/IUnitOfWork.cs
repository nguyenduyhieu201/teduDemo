using System;

namespace quanLyBanHang.Data
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
