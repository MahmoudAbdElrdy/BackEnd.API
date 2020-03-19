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
    public class AboutUsController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesAboutUs _AboutUsServices;
        public AboutUsController(IServicesAboutUs AboutUsServices)
        {
            _AboutUsServices = AboutUsServices;
        }
        #endregion

        #region Post: api/AboutUs/SaveAboutUs
        [HttpPost]
        [Route("SaveAboutUs")]
        public IResponseDTO postAboutUs(AboutUsVM AboutUsVM)
        {
            var depart = _AboutUsServices.PostAboutUs(AboutUsVM);
            return depart;
        }
        #endregion

        #region Put: api/AboutUs/UpdateAboutUs
        [HttpPut]
        [Route("UpdateAboutUs")]
        public IResponseDTO UpdateAboutUs(AboutUsVM AboutUsVM)
        {
            var depart = _AboutUsServices.EditAboutUs(AboutUsVM);
            return depart;
        }
        #endregion

        #region Get: api/AboutUs/GetAllAboutUs
        [HttpGet]
        [Route("GetAllAboutUs")]
        public IResponseDTO GetAllAboutUs()
        {
            var depart = _AboutUsServices.GetAllAboutUs();
            return depart;
        }
        #endregion

        #region Get: api/AboutUs/GetAboutUsById
        [HttpGet]
        [Route("GetAboutUsById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _AboutUsServices.GetByIDAboutUs(id);
            return depart;
        }
        #endregion

        #region Get: api/AboutUs/GetAboutUs
        [HttpGet]
        [Route("GetAboutUs")]
        public IResponseDTO GetAboutUs()
        {
            var depart = _AboutUsServices.GetAboutUs();
            return depart;
        }
        #endregion

        #region Delete: api/AboutUs/RemoveAboutUs
        [HttpDelete]
        [Route("RemoveAboutUs")]
        public IResponseDTO RemoveAboutUs(AboutUsVM AboutUsVM)
        {
            var depart = _AboutUsServices.DeleteAboutUs(AboutUsVM);
            return depart;
        }
        #endregion
    }
}