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
        public IResponseDTO postAdvertisement(AdvertisementIncloudVM AdvertisementVM)
        {
            var depart = _AdvertisementServices.PostAdvertisement(AdvertisementVM);
            return depart;
        }
        #endregion

        //#region Post: api/Advertisement/NewSaveAdvertisement
        //[HttpPost]
        //[Route("NewSaveAdvertisement")]
        //public IResponseDTO NewSaveAdvertisement([FromForm]AdvertisementImageVM AdvertisementVM)
        //{
        //    ResponseDTO res;
        //    try
        //    {
        //        if (AdvertisementVM.Image != null)
        //        {
        //            var logoUrl = UploadHelper.SaveFile(AdvertisementVM.Image, "AdsImage");
        //            AdvertisementVM.AdsImage = logoUrl;
        //        }
        //        if (AdvertisementVM.Video != null)
        //        {
        //            var VideoUrl = UploadHelper.SaveFile(AdvertisementVM.Video, "AdsVideo");
        //            AdvertisementVM.AdsVideo = VideoUrl;
        //        }
        //        return _AdvertisementServices.PostAdvertisement(new AdvertisementIncloudVM()
        //        {
        //            AdsId = Guid.NewGuid(),
        //            AdsText = AdvertisementVM.AdsText,
        //            AdsImage = AdvertisementVM.AdsImage,
        //            AdsType = AdvertisementVM.AdsType,
        //            AdsVideo = AdvertisementVM.AdsVideo,
        //            Available = AdvertisementVM.Available,
        //            CategoryId = AdvertisementVM.CategoryId,
        //            CityId = AdvertisementVM.CityId,
        //            CreationDate = AdvertisementVM.CreationDate,
        //            MarketId = AdvertisementVM.MarketId,
        //            WaitingUpdate = AdvertisementVM.WaitingUpdate,
        //            EndDate = AdvertisementVM.EndDate,
        //            Special = AdvertisementVM.Special,
        //            StartDate = AdvertisementVM.StartDate,
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        res = new ResponseDTO()
        //        {
        //            IsPassed = false,
        //            Message = "Error in UploadMarketLog " + ex.Message,
        //            Data = null,
        //        };
        //    }
        //    return res;
        //}
        //#endregion

        #region Post: api/Advertisement/NewSaveAdvertisementAttach
        [HttpPost]
        [Route("NewSaveAdvertisementAttach")]
        public IResponseDTO NewSaveAdvertisementAttach([FromForm]AdvertisementAttachFileVM AdvertisementVM)
        {
            ResponseDTO res;
            try
            {
                if (AdvertisementVM.File != null)
                {
                    var logoUrl = UploadHelper.SaveFile(AdvertisementVM.File, "AdsFile");
                    AdvertisementVM.AttachUrl = logoUrl;
                }
                return _AdvertisementServices.PostAdvertisementAttach(new AdvertisementAttachVM()
                {
                    AdsAttachId = Guid.NewGuid(),
                    AdsId = AdvertisementVM.AdsId,
                    AttachUrl = AdvertisementVM.AttachUrl,
                    CreationDate = AdvertisementVM.CreationDate,
                    AttachType = AdvertisementVM.AttachType,
                    Notes = AdvertisementVM.Notes,
                    Available = AdvertisementVM.Available
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
        public IResponseDTO GetNewAdvertisement(int page,Guid CustomerId)
        {
            var depart = _AdvertisementServices.GetNewAdvertisement(page, CustomerId);
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

        #region Get: api/Advertisement/GetAdvertisementDetails
        [HttpGet]
        [Route("GetAdvertisementDetails")]
        public IResponseDTO GetAdvertisementDetails(Guid id, Guid CustomerId)
        {
            var depart = _AdvertisementServices.GetAdvertisementDetails(id, CustomerId);
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

        #region Get: api/Advertisement/GetAdvertisementByCategoryForAllCity
        [HttpGet]
        [Route("GetAdvertisementByCategoryForAllCity")]
        public IResponseDTO GetAdvertisementByCategoryForAllCity(int page, Guid categoryId , Guid CustomerId)
        {
            var depart = _AdvertisementServices.GetAdvertisementByCategoryForAllCity(page, categoryId, CustomerId);
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

        #region Get: api/City/GetAllAdvertisementSTP
        [HttpGet]
        [Route("GetAllAdvertisementSTP")]
        public IResponseDTO GetAllAdvertisementSTP()
        {
            var depart = _AdvertisementServices.GetAllAdvertisementSTP();
            return depart;
        }
        #endregion
    }
}