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
    public class AdvertisementOpenServices : IServicesAdvertisementOpen
    {
        private readonly IGRepository<AdvertisementOpen> _AdvertisementOpenRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public AdvertisementOpenServices(IGRepository<AdvertisementOpen> AdvertisementOpen,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _AdvertisementOpenRepositroy = AdvertisementOpen;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteAdvertisementOpen(AdvertisementOpenVM model)
        {
            try
            {

                var DbAdvertisementOpen = _mapper.Map<AdvertisementOpen>(model);
                var entityEntry = _AdvertisementOpenRepositroy.Remove(DbAdvertisementOpen);


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
        public IResponseDTO EditAdvertisementOpen(AdvertisementOpenVM model)
        {
            try
            {
                var DbAdvertisementOpen = _mapper.Map<AdvertisementOpen>(model);
                var entityEntry = _AdvertisementOpenRepositroy.Update(DbAdvertisementOpen);

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
        public IResponseDTO GetAllAdvertisementOpen()
        {
            try
            {
                var AdvertisementOpens = _AdvertisementOpenRepositroy.GetAll();


                var AdvertisementOpensList = _mapper.Map<List<AdvertisementOpenVM>>(AdvertisementOpens);
                _response.Data = AdvertisementOpensList;
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
        public IResponseDTO GetByIDAdvertisementOpen(object id)
        {
            try
            {
                var AdvertisementOpens = _AdvertisementOpenRepositroy.Find(id);


                var AdvertisementOpensList = _mapper.Map<AdvertisementOpenVM>(AdvertisementOpens);
                _response.Data = AdvertisementOpensList;
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
        public IResponseDTO PostAdvertisementOpen(AdvertisementOpenVM model)
        {

            try
            {
                var DbAdvertisementOpen = _mapper.Map<AdvertisementOpen>(model);
                var AdvertisementOpen = _mapper.Map<AdvertisementOpenVM>(_AdvertisementOpenRepositroy.Add(DbAdvertisementOpen));

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
