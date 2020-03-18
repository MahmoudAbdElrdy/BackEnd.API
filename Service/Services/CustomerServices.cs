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
    public class CustomerServices : IServicesCustomer
    {
        private readonly IGRepository<Customer> _CustomerRepositroy;
        private readonly IUnitOfWork<LoGooContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public CustomerServices(IGRepository<Customer> Customer,
            IUnitOfWork<LoGooContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _CustomerRepositroy = Customer;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteCustomer(CustomerVM model)
        {
            try
            {

                var DbCustomer = _mapper.Map<Customer>(model);
                var entityEntry = _CustomerRepositroy.Remove(DbCustomer);


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
        public IResponseDTO EditCustomer(CustomerVM model)
        {
            try
            {
                var DbCustomer = _mapper.Map<Customer>(model);
                var entityEntry = _CustomerRepositroy.Update(DbCustomer);


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
        public IResponseDTO GetAllCustomer()
        {
            try
            {
                var Customers = _CustomerRepositroy.GetAll();


                var CustomersList = _mapper.Map<List<CustomerVM>>(Customers);
                _response.Data = CustomersList;
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
        public IResponseDTO GetByIDCustomer(object id)
        {
            try
            {
                var Customers = _CustomerRepositroy.Find(id);


                var CustomersList = _mapper.Map<CustomerVM>(Customers);
                _response.Data = CustomersList;
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
        public IResponseDTO SubscribeCustomer(DTO.CustomerSubscribeDTO model)
        {
            try
            {
                var customer = new CustomerVM()
                {
                    CustomerId = Guid.NewGuid(),
                    Cityid = model.Cityid,
                    CreationDate = DateTime.UtcNow.AddHours(3),
                    Token = model.Token,
                    Plateform = model.Plateform,
                };
                var DbCustomer = _mapper.Map<Customer>(customer);

                var Customer = _mapper.Map<CustomerVM>(_CustomerRepositroy.Add(DbCustomer));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = customer;
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
        public IResponseDTO RefreshCustomerToken(DTO.CustomerTokenDTO model)
        {
            try
            {
                var Customers = _CustomerRepositroy.Find(model.CustomerId);
                Customers.Token = model.Token;
                var entityEntry = _CustomerRepositroy.Update(Customers);
                int save = _unitOfWork.Commit();
                if (save == 200)
                {
                    _response.Data = Customers;
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
        public IResponseDTO PostCustomer(CustomerVM model)
        {

            try
            {
                var DbCustomer = _mapper.Map<Customer>(model);

                var Customer = _mapper.Map<CustomerVM>(_CustomerRepositroy.Add(DbCustomer));

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
    }
}
