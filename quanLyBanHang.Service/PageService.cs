using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyBanHang.Data.Infrastructure;
using quanLyBanHang.Data.Repositories;
using quanLyBanHang.Model.Models;
using System.Linq;

namespace quanLyBanHang.Service
{
    public interface IPageService
    {
        Page GetByAlias(string alias);
    }
    public class PageService : IPageService
    {
        IPageRepository _pageRepository;
        IUnitOfWork _unitOfWork;
        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }
        public Page GetByAlias(string alias)
        {
            return _pageRepository.GetSingleByCondition(x => x.Alias == alias);
        }
    }
}
