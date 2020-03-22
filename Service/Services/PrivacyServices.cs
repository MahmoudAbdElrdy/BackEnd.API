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
    public class PrivacyServices : IServicesPrivacy
    {
        private readonly IGRepository<Privacy> _PrivacyRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public PrivacyServices(IGRepository<Privacy> Privacy,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _PrivacyRepositroy = Privacy;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeletePrivacy(PrivacyVM model)
        {
            try
            {
                var DbPrivacy = _mapper.Map<Privacy>(model);
                var entityEntry = _PrivacyRepositroy.Remove(DbPrivacy);

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
        public IResponseDTO EditPrivacy(PrivacyVM model)
        {
            try
            {
                var DbPrivacy = _mapper.Map<Privacy>(model);
                var entityEntry = _PrivacyRepositroy.Update(DbPrivacy);
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
        public IResponseDTO GetAllPrivacy()
        {
            try
            {
                var Privacys = _PrivacyRepositroy.GetAll();

                var PrivacysList = _mapper.Map<List<PrivacyVM>>(Privacys);
                _response.Data = PrivacysList;
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
        public IResponseDTO GetByIDPrivacy(object id)
        {
            try
            {
                var Privacys = _PrivacyRepositroy.Find(id);

                var PrivacysList = _mapper.Map<PrivacyVM>(Privacys);
                _response.Data = PrivacysList;
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
        public IResponseDTO PostPrivacy(PrivacyVM model)
        {
            try
            {
                var DbPrivacy = _mapper.Map<Privacy>(model);
                var Privacy = _mapper.Map<PrivacyVM>(_PrivacyRepositroy.Add(DbPrivacy));
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
