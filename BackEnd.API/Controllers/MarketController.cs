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
    public class MarketController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesMarket _MarketServices;
        public MarketController(IServicesMarket MarketServices)
        {
            _MarketServices = MarketServices;
        }
        #endregion

        #region Post: api/Market/SaveMarket
        [HttpPost]
        [Route("SaveMarket")]
        public IResponseDTO postMarket(MarketVM MarketVM)
        {
            var depart = _MarketServices.PostMarket(MarketVM);
            return depart;
        }
        #endregion

        //#region Post: api/Market/SignupMarket
        //[HttpPost]
        //[Route("SignupMarket")]
        //public IResponseDTO SignupMarket(MarketVM MarketVM)
        //{
        //    ResponseDTO res;
        //    try
        //    {
        //        if (Request.Form.Files["MarkeImage"] != null)
        //        {
        //            var logoUrl = UploadHelper.SaveFile(Request.Form.Files["MarkeImage"], "logo");
        //            MarketVM.MarketLogo = logoUrl;
        //        }
        //        return _MarketServices.PostMarket(MarketVM);
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

        //#region Post: api/Market/SignupMarket3
        //[HttpPost]
        //[Route("SignupMarket3")]
        //public IResponseDTO SignupMarket3(MarketImageVM MarketVM)
        //{
        //    ResponseDTO res;
        //    try
        //    {
        //        var logoUrl = UploadHelper.SaveFile(MarketVM.Image, "logo");
        //        MarketVM.MarketLogo = logoUrl;
        //        return _MarketServices.PostMarket(new MarketVM()
        //        {
        //            CityId = MarketVM.CityId,
        //            MarketAddress = MarketVM.MarketAddress,
        //            MarketEmail = MarketVM.MarketEmail,
        //            MarketInfo = MarketVM.MarketInfo,
        //            MarketLatlng = MarketVM.MarketLatlng,
        //            MarketName = MarketVM.MarketName,
        //            MarketPassword = MarketVM.MarketPassword,
        //            MarketPhone = MarketVM.MarketPhone,
        //            Plateform = MarketVM.Plateform,
        //            Token = MarketVM.Token,
        //            MarketLogo = logoUrl,
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

        //#region Get: api/Market/SignupMarket4
        //[HttpGet]
        //[Route("SignupMarket4")]
        //public IResponseDTO SignupMarket4(string MarketName, string MarketAddress, string MarketPhone, string MarketEmail, string MarketPassword, string MarketInfo, bool Plateform, Guid CityId, string Token, string MarketLatlng)
        //{
        //    ResponseDTO res;
        //    try
        //    {

        //        var logoUrl = UploadHelper.SaveFile(Request.Form.Files[0], "logo");
        //        MarketVM MarketVM = new MarketVM()
        //        {
        //            CityId = CityId,
        //            MarketAddress = MarketAddress,
        //            MarketEmail = MarketEmail,
        //            MarketInfo = MarketInfo,
        //            MarketLatlng = MarketLatlng,
        //            MarketName = MarketName,
        //            MarketPassword = MarketPassword,
        //            MarketPhone = MarketPhone,
        //            Plateform = Plateform,
        //            Token = Token,
        //            MarketLogo = logoUrl,
        //        };
        //        return _MarketServices.PostMarket(MarketVM);
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

        //#region Post: api/Market/SignupMarket5
        //[HttpPost]
        //[Route("SignupMarket5")]
        //public IResponseDTO SignupMarket5(ModelBinding.MarketImageModel model)
        //{
        //    ResponseDTO res;
        //    try
        //    {
        //        var logoUrl = UploadHelper.SaveFile(model.Image, "logo");
        //        model.Market.MarketLogo = logoUrl;
        //        return _MarketServices.PostMarket(model.Market);
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
        //#region Post: api/Market/SignupMarket2
        //[HttpPost]
        //[Route("SignupMarket2")]
        //public IResponseDTO SignupMarket2(string MarketName, string MarketAddress, string MarketPhone, string MarketEmail, string MarketPassword, string MarketInfo, bool Plateform, Guid CityId, string Token, string MarketLatlng)
        //{
        //    ResponseDTO res;
        //    try
        //    {

        //        var logoUrl = UploadHelper.SaveFile(Request.Form.Files[0], "logo");
        //        MarketVM MarketVM = new MarketVM()
        //        {
        //            CityId = CityId,
        //            MarketAddress = MarketAddress,
        //            MarketEmail = MarketEmail,
        //            MarketInfo = MarketInfo,
        //            MarketLatlng = MarketLatlng,
        //            MarketName = MarketName,
        //            MarketPassword = MarketPassword,
        //            MarketPhone = MarketPhone,
        //            Plateform = Plateform,
        //            Token = Token,
        //            MarketLogo = logoUrl,
        //        };
        //        return _MarketServices.PostMarket(MarketVM);
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

        #region Post: api/Market/SignupMarket
        [HttpPost]
        [Route("SignupMarket")]
        public IResponseDTO SignupMarket([FromForm]MarketImageVM MarketVM)
        {
            ResponseDTO res;
            try
            {
                if(MarketVM.Image != null)
                {
                    var logoUrl = UploadHelper.SaveFile(MarketVM.Image, "logo");
                    MarketVM.MarketLogo = logoUrl;
                }
                return _MarketServices.PostMarket(new MarketVM()
                {
                    CityId = MarketVM.CityId,
                    MarketAddress = MarketVM.MarketAddress,
                    MarketEmail = MarketVM.MarketEmail,
                    MarketInfo = MarketVM.MarketInfo,
                    MarketLatlng = MarketVM.MarketLatlng,
                    MarketName = MarketVM.MarketName,
                    MarketPassword = MarketVM.MarketPassword,
                    MarketPhone = MarketVM.MarketPhone,
                    Plateform = MarketVM.Plateform,
                    Token = MarketVM.Token,
                    MarketLogo = MarketVM.MarketLogo,
                    FacebookUrl = MarketVM.FacebookUrl,
                    InstagramUrl = MarketVM.InstagramUrl,
                    SnapchatUrl = MarketVM.SnapchatUrl,
                    TwitterUrl = MarketVM.TwitterUrl,
                    WebSitUrl = MarketVM.WebSitUrl,
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

        #region Post: api/Upload/UploadMarketLog
        [HttpPost]
        //[Consumes("multipart/form-data")]
        [Route("~/api/Upload/UploadMarketLog")]
        public IActionResult Upload()
        {
            //var xx = UploadHelper.SaveFile(Request.Form.Files[0], "logo");
            ////string path = xx[0];
            //return Ok(xx);
            ResponseDTO res;
            try
            {
                var xx = UploadHelper.SaveFile(Request.Form.Files[0], "logo");
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

        #region Post: api/Market/MarketLogin
        [HttpPost]
        [Route("MarketLogin")]
        public IResponseDTO MarketLogin(Service.DTO.MarketLoginDTO Market)
        {
            var depart = _MarketServices.MarketLogin(Market);
            return depart;
        }
        #endregion

        #region Post: api/Market/UpdateMarketToken
        [HttpPost]
        [Route("UpdateMarketToken")]
        public IResponseDTO UpdateMarketToken(Service.DTO.MarketTokenDTO Market)
        {
            var depart = _MarketServices.UpdateMarketToken(Market);
            return depart;
        }
        #endregion

        #region Put: api/Market/UpdateMarket
        [HttpPut]
        [Route("UpdateMarket")]
        public IResponseDTO UpdateMarket(MarketVM MarketVM)
        {
            var depart = _MarketServices.EditMarket(MarketVM);
            return depart;
        }
        #endregion

        #region Post: api/Market/NewUpdateMarket
        [HttpPost]
        [Route("NewUpdateMarket")]
        public IResponseDTO NewUpdateMarket([FromForm]MarketImageVM MarketVM)
        {
            ResponseDTO res;
            try
            {
                if (MarketVM.Image != null)
                {
                    var logoUrl = UploadHelper.SaveFile(MarketVM.Image, "logo");
                    MarketVM.MarketLogo = logoUrl;
                }
                return _MarketServices.EditMarket(new MarketVM()
                {
                    MarketId = MarketVM.MarketId,
                    Available = MarketVM.Available,
                    CreationDate = MarketVM.CreationDate,
                    CityId = MarketVM.CityId,
                    MarketAddress = MarketVM.MarketAddress,
                    MarketEmail = MarketVM.MarketEmail,
                    MarketInfo = MarketVM.MarketInfo,
                    MarketLatlng = string.IsNullOrEmpty(MarketVM.MarketLatlng) ? "" : MarketVM.MarketLatlng,
                    MarketName = MarketVM.MarketName,
                    MarketPassword = MarketVM.MarketPassword,
                    MarketPhone = string.IsNullOrEmpty(MarketVM.MarketPhone) ? "" : MarketVM.MarketPhone,
                    Plateform = MarketVM.Plateform,
                    Token = MarketVM.Token,
                    MarketLogo =  MarketVM.MarketLogo,
                    FacebookUrl = MarketVM.FacebookUrl,
                    InstagramUrl = MarketVM.InstagramUrl,
                    SnapchatUrl = MarketVM.SnapchatUrl,
                    TwitterUrl = MarketVM.TwitterUrl,
                    WebSitUrl = MarketVM.WebSitUrl,
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

        #region Get: api/Market/GetAllMarket
        [HttpGet]
        [Route("GetAllMarket")]
        public IResponseDTO GetAllMarket()
        {
            var depart = _MarketServices.GetAllMarket();
            return depart;
        }
        #endregion

        #region Get: api/Market/GetMarketById
        [HttpGet]
        [Route("GetMarketById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _MarketServices.GetByIDMarket(id);
            return depart;
        }
        #endregion

        #region Delete: api/Market/RemoveMarket
        [HttpDelete]
        [Route("RemoveMarket")]
        public IResponseDTO RemoveMarket(MarketVM MarketVM)
        {
            var depart = _MarketServices.DeleteMarket(MarketVM);
            return depart;
        }
        #endregion

        #region Get: api/Market/GetAllMarketContorlPanel
        [HttpGet]
        [Route("GetAllMarketContorlPanel")]
        public IResponseDTO GetAllMarketContorlPanel()
        {
            var depart = _MarketServices.GetAllMarketContorlPanel();
            return depart;
        }
        #endregion
    }
}