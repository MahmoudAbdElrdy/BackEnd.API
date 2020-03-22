using AutoMapper;
using BackEnd.DAL.Models;
using BackEnd.Repositories.Generics;
using BackEnd.Repositories.UOW;
using BackEnd.Service.IServices;
using BackEnd.Service.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Service.Services
{
    public class CustomerLoginServices : IServicesCustomerLogin
    {
        private readonly IGRepository<CustomerLogin> _CustomerLoginRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public CustomerLoginServices(IGRepository<CustomerLogin> CustomerLogin,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _CustomerLoginRepositroy = CustomerLogin;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteCustomerLogin(CustomerLoginVM model)
        {
            try
            {

                var DbCustomerLogin = _mapper.Map<CustomerLogin>(model);
                var entityEntry = _CustomerLoginRepositroy.Remove(DbCustomerLogin);


                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = null;
                    _response.IsPassed = true;
                    _response.Message = "Ok";
                }
                else
                {
                    _response.Data = null;
                    _response.IsPassed = false;
                    _response.Message = "Not saved";
                }
            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.IsPassed = false;
                _response.Message = "Error " + ex.Message;
            }
            return _response;
        }

        public IResponseDTO EditCustomerLogin(CustomerLoginVM model)
        {
            try
            {
                var DbCustomerLogin = _mapper.Map<CustomerLogin>(model);
                var entityEntry = _CustomerLoginRepositroy.Update(DbCustomerLogin);


                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = model;
                    _response.IsPassed = true;
                    _response.Message = "Ok";
                }
                else
                {
                    _response.Data = null;
                    _response.IsPassed = false;
                    _response.Message = "Not saved";
                }
            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.IsPassed = false;
                _response.Message = "Error " + ex.Message;
            }

            return _response;

        }

        public IResponseDTO GetAllCustomerLogin()
        {
            try
            {
                var CustomerLogins = _CustomerLoginRepositroy.GetAll();


                var CustomerLoginsList = _mapper.Map<List<CustomerLoginVM>>(CustomerLogins);
                _response.Data = CustomerLoginsList;
                _response.IsPassed = true;
                _response.Message = "Done";
            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.IsPassed = false;
                _response.Message = "Error " + ex.Message;
            }
            return _response;

        }
        public IResponseDTO GetByIDCustomerLogin(object id)
        {
            try
            {
                var CustomerLogins = _CustomerLoginRepositroy.Find(id);


                var CustomerLoginsList = _mapper.Map<CustomerLoginVM>(CustomerLogins);
                _response.Data = CustomerLoginsList;
                _response.IsPassed = true;
                _response.Message = "Done";
            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.IsPassed = false;
                _response.Message = "Error " + ex.Message;
            }
            return _response;

        }
        public IResponseDTO PostCustomerLogin(CustomerLoginVM model)
        {

            try
            {
                var DbCustomerLogin = _mapper.Map<CustomerLogin>(model);

                var CustomerLogin = _mapper.Map<CustomerLoginVM>(_CustomerLoginRepositroy.Add(DbCustomerLogin));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = model;
                    _response.IsPassed = true;
                    _response.Message = "Ok";
                }
                else
                {
                    _response.Data = null;
                    _response.IsPassed = false;
                    _response.Message = "Not saved";
                }

            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.IsPassed = false;
                _response.Message = "Error " + ex.Message;
            }


            return _response;

        }
        public IResponseDTO NewCustomerLogin(Guid customer_id)
        {

            try
            {
                var customerLogin = new CustomerLoginVM()
                {
                    LoginId = Guid.NewGuid(),
                    Customerid = customer_id,
                    LoginDate = DateTime.UtcNow.AddHours(3),                    
                };
                var DbCustomerLogin = _mapper.Map<CustomerLogin>(customerLogin);

                var CustomerLogin = _mapper.Map<CustomerLoginVM>(_CustomerLoginRepositroy.Add(DbCustomerLogin));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = customerLogin;
                    _response.IsPassed = true;
                    _response.Message = "Ok";
                }
                else
                {
                    _response.Data = null;
                    _response.IsPassed = false;
                    _response.Message = "Not saved";
                }

            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.IsPassed = false;
                _response.Message = "Error " + ex.Message;
            }


            return _response;

        }
    }
}
