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
    public class AdvertisementOpenController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesAdvertisementOpen _AdvertisementOpenServices;
        public AdvertisementOpenController(IServicesAdvertisementOpen AdvertisementOpenServices)
        {
            _AdvertisementOpenServices = AdvertisementOpenServices;
        }
        #endregion

        #region Post: api/AdvertisementOpen/SaveAdvertisementOpen
        [HttpPost]
        [Route("SaveAdvertisementOpen")]
        public IResponseDTO postAdvertisementOpen(AdvertisementOpenVM AdvertisementOpenVM)
        {
            var depart = _AdvertisementOpenServices.PostAdvertisementOpen(AdvertisementOpenVM);
            return depart;
        }
        #endregion

        #region Put: api/AdvertisementOpen/UpdateAdvertisementOpen
        [HttpPut]
        [Route("UpdateAdvertisementOpen")]
        public IResponseDTO UpdateAdvertisementOpen(AdvertisementOpenVM AdvertisementOpenVM)
        {
            var depart = _AdvertisementOpenServices.EditAdvertisementOpen(AdvertisementOpenVM);
            return depart;
        }
        #endregion

        #region Get: api/AdvertisementOpen/GetAllAdvertisementOpen
        [HttpGet]
        [Route("GetAllAdvertisementOpen")]
        public IResponseDTO GetAllAdvertisementOpen()
        {
            var depart = _AdvertisementOpenServices.GetAllAdvertisementOpen();
            return depart;
        }
        #endregion

        #region Get: api/AdvertisementOpen/GetAdvertisementOpenById
        [HttpGet]
        [Route("GetAdvertisementOpenById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _AdvertisementOpenServices.GetByIDAdvertisementOpen(id);
            return depart;
        }
        #endregion

        #region Delete: api/AdvertisementOpen/RemoveAdvertisementOpen
        [HttpDelete]
        [Route("RemoveAdvertisementOpen")]
        public IResponseDTO RemoveAdvertisementOpen(AdvertisementOpenVM AdvertisementOpenVM)
        {
            var depart = _AdvertisementOpenServices.DeleteAdvertisementOpen(AdvertisementOpenVM);
            return depart;
        }
        #endregion
    }
}