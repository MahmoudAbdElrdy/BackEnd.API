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
    public class AdvertisementUpdateController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesAdvertisementUpdate _AdvertisementUpdateServices;
        public AdvertisementUpdateController(IServicesAdvertisementUpdate AdvertisementUpdateServices)
        {
            _AdvertisementUpdateServices = AdvertisementUpdateServices;
        }
        #endregion

        #region Post: api/AdvertisementUpdate/SaveAdvertisementUpdate
        [HttpPost]
        [Route("SaveAdvertisementUpdate")]
        public IResponseDTO postAdvertisementUpdate(AdvertisementUpdateVM AdvertisementUpdateVM)
        {
            var depart = _AdvertisementUpdateServices.PostAdvertisementUpdate(AdvertisementUpdateVM);
            return depart;
        }
        #endregion

        #region Put: api/AdvertisementUpdate/UpdateAdvertisementUpdate
        [HttpPut]
        [Route("UpdateAdvertisementUpdate")]
        public IResponseDTO UpdateAdvertisementUpdate(AdvertisementUpdateVM AdvertisementUpdateVM)
        {
            var depart = _AdvertisementUpdateServices.EditAdvertisementUpdate(AdvertisementUpdateVM);
            return depart;
        }
        #endregion

        #region Get: api/AdvertisementUpdate/GetAllAdvertisementUpdate
        [HttpGet]
        [Route("GetAllAdvertisementUpdate")]
        public IResponseDTO GetAllAdvertisementUpdate()
        {
            var depart = _AdvertisementUpdateServices.GetAllAdvertisementUpdate();
            return depart;
        }
        #endregion

        #region Get: api/AdvertisementUpdate/GetAdvertisementUpdateById
        [HttpGet]
        [Route("GetAdvertisementUpdateById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _AdvertisementUpdateServices.GetByIDAdvertisementUpdate(id);
            return depart;
        }
        #endregion

        #region Delete: api/AdvertisementUpdate/RemoveAdvertisementUpdate
        [HttpDelete]
        [Route("RemoveAdvertisementUpdate")]
        public IResponseDTO RemoveAdvertisementUpdate(AdvertisementUpdateVM AdvertisementUpdateVM)
        {
            var depart = _AdvertisementUpdateServices.DeleteAdvertisementUpdate(AdvertisementUpdateVM);
            return depart;
        }
        #endregion
    }
}