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
    public class ContactUsMarketController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesContactUsMarket _ContactUsMarketServices;
        public ContactUsMarketController(IServicesContactUsMarket ContactUsMarketServices)
        {
            _ContactUsMarketServices = ContactUsMarketServices;
        }
        #endregion

        #region Post: api/ContactUsMarket/SaveContactUsMarket
        [HttpPost]
        [Route("SaveContactUsMarket")]
        public IResponseDTO postContactUsMarket(ContactUsMarketVM ContactUsMarketVM)
        {
            var depart = _ContactUsMarketServices.PostContactUsMarket(ContactUsMarketVM);
            return depart;
        }
        #endregion

        #region Put: api/ContactUsMarket/UpdateContactUsMarket
        [HttpPut]
        [Route("UpdateContactUsMarket")]
        public IResponseDTO UpdateContactUsMarket(ContactUsMarketVM ContactUsMarketVM)
        {
            var depart = _ContactUsMarketServices.EditContactUsMarket(ContactUsMarketVM);
            return depart;
        }
        #endregion

        #region Get: api/ContactUsMarket/GetAllContactUsMarket
        [HttpGet]
        [Route("GetAllContactUsMarket")]
        public IResponseDTO GetAllContactUsMarket()
        {
            var depart = _ContactUsMarketServices.GetAllContactUsMarket();
            return depart;
        }
        #endregion

        #region Get: api/ContactUsMarket/GetContactUsMarketById
        [HttpGet]
        [Route("GetContactUsMarketById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _ContactUsMarketServices.GetByIDContactUsMarket(id);
            return depart;
        }
        #endregion

        #region Delete: api/ContactUsMarket/RemoveContactUsMarket
        [HttpDelete]
        [Route("RemoveContactUsMarket")]
        public IResponseDTO RemoveContactUsMarket(ContactUsMarketVM ContactUsMarketVM)
        {
            var depart = _ContactUsMarketServices.DeleteContactUsMarket(ContactUsMarketVM);
            return depart;
        }
        #endregion
    }
}