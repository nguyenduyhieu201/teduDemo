using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Model.Models;

namespace quanLyBanHang.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        
    }
}