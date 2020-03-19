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
    public class AdvertisementViewController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesAdvertisementView _AdvertisementViewServices;
        public AdvertisementViewController(IServicesAdvertisementView AdvertisementViewServices)
        {
            _AdvertisementViewServices = AdvertisementViewServices;
        }
        #endregion

        #region Post: api/AdvertisementView/SaveAdvertisementView
        [HttpPost]
        [Route("SaveAdvertisementView")]
        public IResponseDTO postAdvertisementView(AdvertisementViewVM AdvertisementViewVM)
        {
            var depart = _AdvertisementViewServices.PostAdvertisementView(AdvertisementViewVM);
            return depart;
        }
        #endregion

        #region Put: api/AdvertisementView/UpdateAdvertisementView
        [HttpPut]
        [Route("UpdateAdvertisementView")]
        public IResponseDTO UpdateAdvertisementView(AdvertisementViewVM AdvertisementViewVM)
        {
            var depart = _AdvertisementViewServices.EditAdvertisementView(AdvertisementViewVM);
            return depart;
        }
        #endregion

        #region Get: api/AdvertisementView/GetAllAdvertisementView
        [HttpGet]
        [Route("GetAllAdvertisementView")]
        public IResponseDTO GetAllAdvertisementView()
        {
            var depart = _AdvertisementViewServices.GetAllAdvertisementView();
            return depart;
        }
        #endregion

        #region Get: api/AdvertisementView/GetAdvertisementViewById
        [HttpGet]
        [Route("GetAdvertisementViewById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _AdvertisementViewServices.GetByIDAdvertisementView(id);
            return depart;
        }
        #endregion

        #region Delete: api/AdvertisementView/RemoveAdvertisementView
        [HttpDelete]
        [Route("RemoveAdvertisementView")]
        public IResponseDTO RemoveAdvertisementView(AdvertisementViewVM AdvertisementViewVM)
        {
            var depart = _AdvertisementViewServices.DeleteAdvertisementView(AdvertisementViewVM);
            return depart;
        }
        #endregion
    }
}