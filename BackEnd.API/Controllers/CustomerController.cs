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
    public class CustomerController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesCustomer _CustomerServices;
        public CustomerController(IServicesCustomer CustomerServices)
        {
            _CustomerServices = CustomerServices;
        }
        #endregion

        #region Post: api/Customer/SaveCustomer
        [HttpPost]
        [Route("SaveCustomer")]
        public IResponseDTO postCustomer(CustomerVM CustomerVM)
        {
            var depart = _CustomerServices.PostCustomer(CustomerVM);
            return depart;
        }
        #endregion

        #region Post: api/Customer/SubscribeCustomer
        [HttpPost]
        [Route("SubscribeCustomer")]
        public IResponseDTO SubscribeCustomer(Service.DTO.CustomerSubscribeDTO Customer)
        {
            var depart = _CustomerServices.SubscribeCustomer(Customer);
            return depart;
        }
        #endregion

        #region Post: api/Customer/RefreshCustomerToken
        [HttpPost]
        [Route("RefreshCustomerToken")]
        public IResponseDTO RefreshCustomerToken(Service.DTO.CustomerTokenDTO Customer)
        {
            var depart = _CustomerServices.RefreshCustomerToken(Customer);
            return depart;
        }
        #endregion

        #region Put: api/Customer/UpdateCustomer
        [HttpPut]
        [Route("UpdateCustomer")]
        public IResponseDTO UpdateCustomer(CustomerVM CustomerVM)
        {
            var depart = _CustomerServices.EditCustomer(CustomerVM);
            return depart;
        }
        #endregion

        #region Get: api/Customer/GetAllCustomer
        [HttpGet]
        [Route("GetAllCustomer")]
        public IResponseDTO GetAllCustomer()
        {
            var depart = _CustomerServices.GetAllCustomer();
            return depart;
        }
        #endregion

        #region Get: api/Customer/GetCustomerById
        [HttpGet]
        [Route("GetCustomerById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _CustomerServices.GetByIDCustomer(id);
            return depart;
        }
        #endregion

        #region Delete: api/Customer/RemoveCustomer
        [HttpDelete]
        [Route("RemoveCustomer")]
        public IResponseDTO RemoveCustomer(CustomerVM CustomerVM)
        {
            var depart = _CustomerServices.DeleteCustomer(CustomerVM);
            return depart;
        }
        #endregion
    }
}