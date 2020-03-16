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
    public class CountryController : ControllerBase
    {
        private readonly IServicesCountry _CountryServices;
        public CountryController(IServicesCountry CountryServices)
        {
            _CountryServices = CountryServices;

        }
        [HttpPost]
        [Route("Country")]
        public IResponseDTO postCountry(CountryVM CountryVM)
        {
            var depart = _CountryServices.PostCountry(CountryVM);
            return depart;
        }
        [HttpPut]
        [Route("UpdateCountry")]
        public IResponseDTO UpdateCountry(CountryVM CountryVM)
        {
            var depart = _CountryServices.EditCountry(CountryVM);
            return depart;
        }
        [HttpGet]
        [Route("GetAllCountry")]
        public IResponseDTO GetAllCountry()
        {
            var depart = _CountryServices.GetAllCountry();
            return depart;
        }
        [HttpGet]
        [Route("GetById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _CountryServices.GetByIDCountry(id);
            return depart;
        }

        [HttpDelete]
        [Route("RemoveCountry")]
        public IResponseDTO RemoveCountry(CountryVM CountryVM)
        {
            var depart = _CountryServices.DeleteCountry(CountryVM);
            return depart;
        }
    }
}