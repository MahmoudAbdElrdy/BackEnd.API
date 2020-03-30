using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Service.IServices;
using BackEnd.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesCategory _CategoryServices;
        public CategoryController(IServicesCategory CategoryServices)
        {
            _CategoryServices = CategoryServices;
        }
        #endregion

        #region Post: api/Category/SaveCategory
        [HttpPost]
        [Route("SaveCategory")]
        public IResponseDTO postCategory(CategoryVM CategoryVM)
        {
            var depart = _CategoryServices.PostCategory(CategoryVM);
            return depart;
        }
        #endregion

        #region Put: api/Category/UpdateCategory
        [HttpPut]
        [Route("UpdateCategory")]
        public IResponseDTO UpdateCategory(CategoryVM CategoryVM)
        {
            var depart = _CategoryServices.EditCategory(CategoryVM);
            return depart;
        }
        #endregion

        #region Get: api/Category/GetAllCategory
        [HttpGet]
        [Route("GetAllCategory")]
        public IResponseDTO GetAllCategory()
        {
            var depart = _CategoryServices.GetAllCategory();
            return depart;
        }
        #endregion

        #region Get: api/Category/GetCategorysAds
        [HttpGet]
        [Route("GetCategorysAds")]
        public IResponseDTO GetCategorysAds(Guid CustomerId)
        {
            var depart = _CategoryServices.GetCategorysAds(CustomerId);
            return depart;
        }
        #endregion

        #region Get: api/Category/GetCategoryById
        [HttpGet]
        [Route("GetCategoryById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _CategoryServices.GetByIDCategory(id);
            return depart;
        }
        #endregion

        #region Delete: api/Category/RemoveCategory
        [HttpDelete]
        [Route("RemoveCategory")]
        public IResponseDTO RemoveCategory(CategoryVM CategoryVM)
        {
            var depart = _CategoryServices.DeleteCategory(CategoryVM);
            return depart;
        }
        #endregion
    }
}