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
    public class ContactUsController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesContactUs _ContactUsServices;
        public ContactUsController(IServicesContactUs ContactUsServices)
        {
            _ContactUsServices = ContactUsServices;
        }
        #endregion

        #region Post: api/ContactUs/SaveContactUs
        [HttpPost]
        [Route("SaveContactUs")]
        public IResponseDTO postContactUs(ContactUsVM ContactUsVM)
        {
            var depart = _ContactUsServices.PostContactUs(ContactUsVM);
            return depart;
        }
        #endregion

        #region Put: api/ContactUs/UpdateContactUs
        [HttpPut]
        [Route("UpdateContactUs")]
        public IResponseDTO UpdateContactUs(ContactUsVM ContactUsVM)
        {
            var depart = _ContactUsServices.EditContactUs(ContactUsVM);
            return depart;
        }
        #endregion

        #region Get: api/ContactUs/GetAllContactUs
        [HttpGet]
        [Route("GetAllContactUs")]
        public IResponseDTO GetAllContactUs()
        {
            var depart = _ContactUsServices.GetAllContactUs();
            return depart;
        }
        #endregion

        #region Get: api/ContactUs/GetContactUsById
        [HttpGet]
        [Route("GetContactUsById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _ContactUsServices.GetByIDContactUs(id);
            return depart;
        }
        #endregion

        #region Delete: api/ContactUs/RemoveContactUs
        [HttpDelete]
        [Route("RemoveContactUs")]
        public IResponseDTO RemoveContactUs(ContactUsVM ContactUsVM)
        {
            var depart = _ContactUsServices.DeleteContactUs(ContactUsVM);
            return depart;
        }
        #endregion
    }
}