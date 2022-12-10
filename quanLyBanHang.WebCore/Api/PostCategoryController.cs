using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using quanLyBanHang.Model.Models;
using quanLyBanHang.Service;
using quanLyBanHang.Model.Dto;
using quanLyBanHang.Web.Infrastructure.Extensions;
using quanLyBanHang.WebCore.Infrastructure.Core;
using Microsoft.AspNetCore.Mvc;


namespace quanLyBanHang.Web.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostCategoryController : ControllerBase
    {
        private IApiControllerBase _apiControllerBase;
        private IPostCategoryService _postCategoryService;
        private readonly IMapper _mapper;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService,
            IMapper mapper, IApiControllerBase apiControllerBase)
        {
            _apiControllerBase = apiControllerBase;
            _postCategoryService = postCategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage Get( HttpRequestMessage request)
        {
            return _apiControllerBase.CreateHttpResponse(request, () =>
            {
                var listCategory = _postCategoryService.GetAll();
                var listPostCategoryVm = _mapper.Map<List<PostCategoryViewModel>>(listCategory);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);
                return response;
            });
        }

        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Post([FromQuery] HttpRequestMessage request, [FromBody] PostCategoryViewModel postCategoryVm)
        {
            return _apiControllerBase.CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, "create da bi loi");
                }
                else
                {
                    PostCategory newPostCategory = new PostCategory();
                    newPostCategory.UpdatePostCategory(postCategoryVm);

                    var category = _postCategoryService.Add(newPostCategory);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.Created, category);

                }
                return response;
            });
        }

        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Put([FromBody] HttpRequestMessage request,
        [FromQuery] PostCategoryViewModel postCategoryVm)
        {
            return _apiControllerBase.CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, "update fail cmnr");
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);
                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}

//khai báo phương thức Http