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

        #region Post: api/AdvertisementUpdate/NewSaveAdvertisementUpdate
        [HttpPost]
        [Route("NewSaveAdvertisementUpdate")]
        public IResponseDTO NewSaveAdvertisementUpdate([FromForm]AdvertisementImageUpdateVM AdvertisementUpdateVM)
        {
            ResponseDTO res;
            try
            {
                if (AdvertisementUpdateVM.Image == null)
                {
                    var logoUrl = Hlper.UploadHelper.SaveFile(AdvertisementUpdateVM.Image, "AdsImage");
                    AdvertisementUpdateVM.AdsImage = logoUrl;
                }
                if (AdvertisementUpdateVM.Video == null)
                {
                    var VideoUrl = Hlper.UploadHelper.SaveFile(AdvertisementUpdateVM.Video, "AdsVideo");
                    AdvertisementUpdateVM.AdsVideo = VideoUrl;
                }
                return _AdvertisementUpdateServices.PostAdvertisementUpdate(new AdvertisementUpdateVM()
                {
                    AdsUpdateId = Guid.NewGuid(),
                    AdsText = AdvertisementUpdateVM.AdsText,
                    AdsImage = AdvertisementUpdateVM.AdsImage,
                    AdsType = AdvertisementUpdateVM.AdsType,
                    AdsVideo = AdvertisementUpdateVM.AdsVideo,
                    Available = AdvertisementUpdateVM.Available,
                    CityId = AdvertisementUpdateVM.CityId,
                    CreationDate = AdvertisementUpdateVM.CreationDate,
                    EndDate = AdvertisementUpdateVM.EndDate,
                    Special = AdvertisementUpdateVM.Special,
                    StartDate = AdvertisementUpdateVM.StartDate,
                    AdsId = AdvertisementUpdateVM.AdsId,
                });
            }
            catch (Exception ex)
            {
                res = new ResponseDTO()
                {
                    IsPassed = false,
                    Message = "Error in UploadMarketLog " + ex.Message,
                    Data = null,
                };
            }
            return res;
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
        #region watingupdate
        [HttpGet]
        [Route("GetAdvertisementWaitingUpdate")]
        public IResponseDTO WaitingUpdate(Guid? id)
        {
            var depart = _AdvertisementUpdateServices.WaitingUpdate(id);
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