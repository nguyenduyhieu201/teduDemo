using AutoMapper;
using quanLyBanHang.Model.Dto;
using quanLyBanHang.Model.Models;

namespace quanLyBanHang.Web.Mappings
{
    public class AutoMapperConfiguration : Profile
    {
        public void Configure()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}