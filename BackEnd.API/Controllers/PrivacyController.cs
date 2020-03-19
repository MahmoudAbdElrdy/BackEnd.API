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
    public class PrivacyController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesPrivacy _PrivacyServices;
        public PrivacyController(IServicesPrivacy PrivacyServices)
        {
            _PrivacyServices = PrivacyServices;
        }
        #endregion

        #region Post: api/Privacy/SavePrivacy
        [HttpPost]
        [Route("SavePrivacy")]
        public IResponseDTO postPrivacy(PrivacyVM PrivacyVM)
        {
            var depart = _PrivacyServices.PostPrivacy(PrivacyVM);
            return depart;
        }
        #endregion

        #region Put: api/Privacy/UpdatePrivacy
        [HttpPut]
        [Route("UpdatePrivacy")]
        public IResponseDTO UpdatePrivacy(PrivacyVM PrivacyVM)
        {
            var depart = _PrivacyServices.EditPrivacy(PrivacyVM);
            return depart;
        }
        #endregion

        #region Get: api/Privacy/GetAllPrivacy
        [HttpGet]
        [Route("GetAllPrivacy")]
        public IResponseDTO GetAllPrivacy()
        {
            var depart = _PrivacyServices.GetAllPrivacy();
            return depart;
        }
        #endregion

        #region Get: api/Privacy/GetPrivacyById
        [HttpGet]
        [Route("GetPrivacyById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _PrivacyServices.GetByIDPrivacy(id);
            return depart;
        }
        #endregion

        #region Delete: api/Privacy/RemovePrivacy
        [HttpDelete]
        [Route("RemovePrivacy")]
        public IResponseDTO RemovePrivacy(PrivacyVM PrivacyVM)
        {
            var depart = _PrivacyServices.DeletePrivacy(PrivacyVM);
            return depart;
        }
        #endregion
    }
}