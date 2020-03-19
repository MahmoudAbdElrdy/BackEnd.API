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
    public class ContactUsServices : IServicesContactUs
    {
        private readonly IGRepository<ContactUs> _ContactUsRepositroy;
        private readonly IUnitOfWork<LoGooContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public ContactUsServices(IGRepository<ContactUs> ContactUs,
            IUnitOfWork<LoGooContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _ContactUsRepositroy = ContactUs;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteContactUs(ContactUsVM model)
        {
            try
            {
                var DbContactUs = _mapper.Map<ContactUs>(model);
                var entityEntry = _ContactUsRepositroy.Remove(DbContactUs);

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
        public IResponseDTO EditContactUs(ContactUsVM model)
        {
            try
            {
                var DbContactUs = _mapper.Map<ContactUs>(model);
                var entityEntry = _ContactUsRepositroy.Update(DbContactUs);
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
        public IResponseDTO GetAllContactUs()
        {
            try
            {
                var ContactUss = _ContactUsRepositroy.GetAll();

                var ContactUssList = _mapper.Map<List<ContactUsVM>>(ContactUss);
                _response.Data = ContactUssList;
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
        public IResponseDTO GetByIDContactUs(object id)
        {
            try
            {
                var ContactUss = _ContactUsRepositroy.Find(id);

                var ContactUssList = _mapper.Map<ContactUsVM>(ContactUss);
                _response.Data = ContactUssList;
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
        public IResponseDTO PostContactUs(ContactUsVM model)
        {
            try
            {
                var DbContactUs = _mapper.Map<ContactUs>(model);
                var ContactUs = _mapper.Map<ContactUsVM>(_ContactUsRepositroy.Add(DbContactUs));
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
