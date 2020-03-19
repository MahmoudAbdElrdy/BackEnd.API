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
    public class CustomerLoginController : ControllerBase
    {
        #region Private&Constructor
        private readonly IServicesCustomerLogin _CustomerLoginServices;
        public CustomerLoginController(IServicesCustomerLogin CustomerLoginServices)
        {
            _CustomerLoginServices = CustomerLoginServices;
        }
        #endregion

        #region Post: api/CustomerLogin/SaveCustomerLogin
        [HttpPost]
        [Route("SaveCustomerLogin")]
        public IResponseDTO postCustomerLogin(CustomerLoginVM CustomerLoginVM)
        {
            var depart = _CustomerLoginServices.PostCustomerLogin(CustomerLoginVM);
            return depart;
        }
        #endregion

        #region Put: api/CustomerLogin/UpdateCustomerLogin
        [HttpPut]
        [Route("UpdateCustomerLogin")]
        public IResponseDTO UpdateCustomerLogin(CustomerLoginVM CustomerLoginVM)
        {
            var depart = _CustomerLoginServices.EditCustomerLogin(CustomerLoginVM);
            return depart;
        }
        #endregion

        #region Get: api/CustomerLogin/GetAllCustomerLogin
        [HttpGet]
        [Route("GetAllCustomerLogin")]
        public IResponseDTO GetAllCustomerLogin()
        {
            var depart = _CustomerLoginServices.GetAllCustomerLogin();
            return depart;
        }
        #endregion

        #region Get: api/CustomerLogin/GetCustomerLoginById
        [HttpGet]
        [Route("GetCustomerLoginById")]
        public IResponseDTO GetById(Guid ?id)
        {
            var depart = _CustomerLoginServices.GetByIDCustomerLogin(id);
            return depart;
        }
        #endregion

        #region Get: api/CustomerLogin/NewCustomerLogin
        [HttpGet]
        [Route("NewCustomerLogin")]
        public IResponseDTO NewCustomerLogin(Guid customer_id)
        {
            var depart = _CustomerLoginServices.NewCustomerLogin(customer_id);
            return depart;
        }
        #endregion

        #region Delete: api/CustomerLogin/RemoveCustomerLogin
        [HttpDelete]
        [Route("RemoveCustomerLogin")]
        public IResponseDTO RemoveCustomerLogin(CustomerLoginVM CustomerLoginVM)
        {
            var depart = _CustomerLoginServices.DeleteCustomerLogin(CustomerLoginVM);
            return depart;
        }
        #endregion
    }
}