using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.API.Hlper;
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

        #region Get: api/Advertisement/GetNewAdvertisement
        [HttpGet]
        [Route("GetNewAdvertisement")]
        public IResponseDTO GetNewAdvertisement(int page,Guid CustomerId, Guid cityId)
        {
            var depart = _AdvertisementServices.GetNewAdvertisement(page, cityId, CustomerId);
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
        public IResponseDTO GetAdvertisementByMarketId(int page, Guid marketId , Guid? CustomerId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByMarketId(page, marketId, CustomerId);
            return depart;
        }
        #endregion
        
        #region Get: api/Advertisement/GetAdvertisementByCityId
        [HttpGet]
        [Route("GetAdvertisementByCityId")]
        public IResponseDTO GetAdvertisementByCityId(int page, Guid cityId , Guid CustomerId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByCityId(page, cityId, CustomerId);
            return depart;
        }
        #endregion

        #region Get: api/Advertisement/GetAdvertisementByCategory
        [HttpGet]
        [Route("GetAdvertisementByCategory")]
        public IResponseDTO GetAdvertisementByCategory(int page, Guid categoryId, Guid cityId , Guid CustomerId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByCategory(page, categoryId, cityId, CustomerId);
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

        #region Post: api/Upload/UploadAdvertisement
        [HttpPost]
        //[Consumes("multipart/form-data")]
        [Route("~/api/Upload/UploadAdvertisement")]
        public IActionResult Upload()
        {
            ResponseDTO res;
            try
            {
                var xx = UploadHelper.SaveFile(Request.Form.Files[0], "media");
                //string path = xx[0];
                res = new ResponseDTO()
                {
                    IsPassed = true,
                    Message = "",
                    Data = xx,
                };
            }
            catch (Exception ex)
            {
                res = new ResponseDTO()
                {
                    IsPassed = false,
                    Message = "Error " + ex.Message,
                    Data = null,
                };
            }
            return Ok(res);
        }
        #endregion
    }
}