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
    public class AdvertisementUpdateServices : IServicesAdvertisementUpdate
    {
        private readonly IGRepository<AdvertisementUpdate> _AdvertisementUpdateRepositroy;
        private readonly IUnitOfWork<LoGooContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public AdvertisementUpdateServices(IGRepository<AdvertisementUpdate> AdvertisementUpdate,
            IUnitOfWork<LoGooContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _AdvertisementUpdateRepositroy = AdvertisementUpdate;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteAdvertisementUpdate(AdvertisementUpdateVM model)
        {
            try
            {

                var DbAdvertisementUpdate = _mapper.Map<AdvertisementUpdate>(model);
                var entityEntry = _AdvertisementUpdateRepositroy.Remove(DbAdvertisementUpdate);


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
        public IResponseDTO EditAdvertisementUpdate(AdvertisementUpdateVM model)
        {
            try
            {
                var DbAdvertisementUpdate = _mapper.Map<AdvertisementUpdate>(model);
                var entityEntry = _AdvertisementUpdateRepositroy.Update(DbAdvertisementUpdate);


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
        public IResponseDTO GetAllAdvertisementUpdate()
        {
            try
            {
                var AdvertisementUpdates = _AdvertisementUpdateRepositroy.GetAll();


                var AdvertisementUpdatesList = _mapper.Map<List<AdvertisementUpdateVM>>(AdvertisementUpdates);
                _response.Data = AdvertisementUpdatesList;
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
        public IResponseDTO GetByIDAdvertisementUpdate(object id)
        {
            try
            {
                var AdvertisementUpdates = _AdvertisementUpdateRepositroy.Find(id);


                var AdvertisementUpdatesList = _mapper.Map<AdvertisementUpdateVM>(AdvertisementUpdates);
                _response.Data = AdvertisementUpdatesList;
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
        public IResponseDTO PostAdvertisementUpdate(AdvertisementUpdateVM model)
        {

            try
            {
                var DbAdvertisementUpdate = _mapper.Map<AdvertisementUpdate>(model);

                var AdvertisementUpdate = _mapper.Map<AdvertisementUpdateVM>(_AdvertisementUpdateRepositroy.Add(DbAdvertisementUpdate));

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
