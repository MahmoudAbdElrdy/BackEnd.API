﻿using System;
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
    public class AdvertisementController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesAdvertisement _AdvertisementServices;
        public AdvertisementController(IServicesAdvertisement AdvertisementServices)
        {
            _AdvertisementServices = AdvertisementServices;
        }
        #endregion

        #region Post: api/Advertisement/SaveAdvertisement
        [HttpPost]
        [Route("SaveAdvertisement")]
        public IResponseDTO postAdvertisement(AdvertisementVM AdvertisementVM)
        {
            var depart = _AdvertisementServices.PostAdvertisement(AdvertisementVM);
            return depart;
        }
        #endregion

        #region Put: api/Advertisement/UpdateAdvertisement
        [HttpPut]
        [Route("UpdateAdvertisement")]
        public IResponseDTO UpdateAdvertisement(AdvertisementVM AdvertisementVM)
        {
            var depart = _AdvertisementServices.EditAdvertisement(AdvertisementVM);
            return depart;
        }
        #endregion

        #region Get: api/Advertisement/GetAllAdvertisement
        [HttpGet]
        [Route("GetAllAdvertisement")]
        public IResponseDTO GetAllAdvertisement()
        {
            var depart = _AdvertisementServices.GetAllAdvertisement();
            return depart;
        }
        #endregion

        #region Get: api/Advertisement/GetAdvertisementById
        [HttpGet]
        [Route("GetAdvertisementById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _AdvertisementServices.GetByIDAdvertisement(id);
            return depart;
        }
        #endregion

        #region Get: api/Advertisement/GetAdvertisementByMarketId
        [HttpGet]
        [Route("GetAdvertisementByMarketId")]
        public IResponseDTO GetAdvertisementByMarketId(int page, Guid marketId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByMarketId(page, marketId);
            return depart;
        }
        #endregion
        
        #region Get: api/Advertisement/GetAdvertisementByCityId
        [HttpGet]
        [Route("GetAdvertisementByCityId")]
        public IResponseDTO GetAdvertisementByCityId(int page, Guid cityId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByCityId(page, cityId);
            return depart;
        }
        #endregion

        #region Get: api/Advertisement/GetAdvertisementByCategory
        [HttpGet]
        [Route("GetAdvertisementByCategory")]
        public IResponseDTO GetAdvertisementByCategory(int page, Guid categoryId, Guid cityId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByCategory(page, categoryId, cityId);
            return depart;
        }
        #endregion

        #region Delete: api/Advertisement/RemoveAdvertisement
        [HttpDelete]
        [Route("RemoveAdvertisement")]
        public IResponseDTO RemoveAdvertisement(AdvertisementVM AdvertisementVM)
        {
            var depart = _AdvertisementServices.DeleteAdvertisement(AdvertisementVM);
            return depart;
        }
        #endregion
    }
}