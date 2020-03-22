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
    public class AboutUsServices : IServicesAboutUs
    {
        private readonly IGRepository<AboutUs> _AboutUsRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public AboutUsServices(IGRepository<AboutUs> AboutUs,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _AboutUsRepositroy = AboutUs;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteAboutUs(AboutUsVM model)
        {
            try
            {
                var DbAboutUs = _mapper.Map<AboutUs>(model);
                var entityEntry = _AboutUsRepositroy.Remove(DbAboutUs);

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
        public IResponseDTO EditAboutUs(AboutUsVM model)
        {
            try
            {
                var DbAboutUs = _mapper.Map<AboutUs>(model);
                var entityEntry = _AboutUsRepositroy.Update(DbAboutUs);
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
        public IResponseDTO GetAllAboutUs()
        {
            try
            {
                var AboutUss = _AboutUsRepositroy.GetAll();

                var AboutUssList = _mapper.Map<List<AboutUsVM>>(AboutUss);
                _response.Data = AboutUssList;
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
        public IResponseDTO GetByIDAboutUs(object id)
        {
            try
            {
                var AboutUss = _AboutUsRepositroy.Find(id);

                var AboutUssList = _mapper.Map<AboutUsVM>(AboutUss);
                _response.Data = AboutUssList;
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
        public IResponseDTO GetAboutUs()
        {
            try
            {
                var AboutUss = _AboutUsRepositroy.GetFirst();

                var AboutUssList = _mapper.Map<AboutUsVM>(AboutUss);
                _response.Data = AboutUssList;
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
        public IResponseDTO PostAboutUs(AboutUsVM model)
        {
            try
            {
                var DbAboutUs = _mapper.Map<AboutUs>(model);
                var AboutUs = _mapper.Map<AboutUsVM>(_AboutUsRepositroy.Add(DbAboutUs));
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
