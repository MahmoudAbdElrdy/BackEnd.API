//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesCustomerLogin
    {
        IResponseDTO PostCustomerLogin(CustomerLoginVM model);
        IResponseDTO GetAllCustomerLogin();
        IResponseDTO EditCustomerLogin(CustomerLoginVM model);
        IResponseDTO DeleteCustomerLogin(CustomerLoginVM model);
        IResponseDTO GetByIDCustomerLogin(object id);
    }
}
