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
    public class ContactUsMarketServices : IServicesContactUsMarket
    {
        private readonly IGRepository<ContactUsMarket> _ContactUsMarketRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public ContactUsMarketServices(IGRepository<ContactUsMarket> ContactUsMarket,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _ContactUsMarketRepositroy = ContactUsMarket;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteContactUsMarket(ContactUsMarketVM model)
        {
            try
            {
                var DbContactUsMarket = _mapper.Map<ContactUsMarket>(model);
                var entityEntry = _ContactUsMarketRepositroy.Remove(DbContactUsMarket);

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
        public IResponseDTO EditContactUsMarket(ContactUsMarketVM model)
        {
            try
            {
                var DbContactUsMarket = _mapper.Map<ContactUsMarket>(model);
                var entityEntry = _ContactUsMarketRepositroy.Update(DbContactUsMarket);
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
        public IResponseDTO GetAllContactUsMarket()
        {
            try
            {
                var ContactUsMarkets = _ContactUsMarketRepositroy.GetAll();

                var ContactUsMarketsList = _mapper.Map<List<ContactUsMarketVM>>(ContactUsMarkets);
                _response.Data = ContactUsMarketsList;
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
        public IResponseDTO GetByIDContactUsMarket(object id)
        {
            try
            {
                var ContactUsMarkets = _ContactUsMarketRepositroy.Find(id);

                var ContactUsMarketsList = _mapper.Map<ContactUsMarketVM>(ContactUsMarkets);
                _response.Data = ContactUsMarketsList;
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
        public IResponseDTO PostContactUsMarket(ContactUsMarketVM model)
        {
            try
            {
                var DbContactUsMarket = _mapper.Map<ContactUsMarket>(model);
                var ContactUsMarket = _mapper.Map<ContactUsMarketVM>(_ContactUsMarketRepositroy.Add(DbContactUsMarket));
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
