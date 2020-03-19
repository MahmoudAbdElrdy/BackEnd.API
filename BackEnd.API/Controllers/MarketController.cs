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
    }
}