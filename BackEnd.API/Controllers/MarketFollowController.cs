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
    public class MarketFollowController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesMarketFollow _MarketFollowServices;
        public MarketFollowController(IServicesMarketFollow MarketFollowServices)
        {
            _MarketFollowServices = MarketFollowServices;
        }
        #endregion

        #region Post: api/MarketFollow/SaveMarketFollow
        [HttpPost]
        [Route("SaveMarketFollow")]
        public IResponseDTO postMarketFollow(MarketFollowVM MarketFollowVM)
        {
            var depart = _MarketFollowServices.PostMarketFollow(MarketFollowVM);
            return depart;
        }
        #endregion

        #region Put: api/MarketFollow/UpdateMarketFollow
        [HttpPut]
        [Route("UpdateMarketFollow")]
        public IResponseDTO UpdateMarketFollow(MarketFollowVM MarketFollowVM)
        {
            var depart = _MarketFollowServices.EditMarketFollow(MarketFollowVM);
            return depart;
        }
        #endregion

        #region Get: api/MarketFollow/GetAllMarketFollow
        [HttpGet]
        [Route("GetAllMarketFollow")]
        public IResponseDTO GetAllMarketFollow()
        {
            var depart = _MarketFollowServices.GetAllMarketFollow();
            return depart;
        }
        #endregion

        #region Get: api/MarketFollow/GetMarketFollowById
        [HttpGet]
        [Route("GetMarketFollowById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _MarketFollowServices.GetByIDMarketFollow(id);
            return depart;
        }
        #endregion

        #region Delete: api/MarketFollow/RemoveMarketFollow
        [HttpDelete]
        [Route("RemoveMarketFollow")]
        public IResponseDTO RemoveMarketFollow(MarketFollowVM MarketFollowVM)
        {
            var depart = _MarketFollowServices.DeleteMarketFollow(MarketFollowVM);
            return depart;
        }
        #endregion
    }
}