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
    public class AdvertisementViewServices : IServicesAdvertisementView
    {
        private readonly IGRepository<AdvertisementView> _AdvertisementViewRepositroy;
        private readonly IUnitOfWork<LoGooContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public AdvertisementViewServices(IGRepository<AdvertisementView> AdvertisementView,
            IUnitOfWork<LoGooContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _AdvertisementViewRepositroy = AdvertisementView;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteAdvertisementView(AdvertisementViewVM model)
        {
            try
            {

                var DbAdvertisementView = _mapper.Map<AdvertisementView>(model);
                var entityEntry = _AdvertisementViewRepositroy.Remove(DbAdvertisementView);


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

        public IResponseDTO EditAdvertisementView(AdvertisementViewVM model)
        {
            try
            {
                var DbAdvertisementView = _mapper.Map<AdvertisementView>(model);
                var entityEntry = _AdvertisementViewRepositroy.Update(DbAdvertisementView);


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

        public IResponseDTO GetAllAdvertisementView()
        {
            try
            {
                var AdvertisementViews = _AdvertisementViewRepositroy.GetAll();


                var AdvertisementViewsList = _mapper.Map<List<AdvertisementViewVM>>(AdvertisementViews);
                _response.Data = AdvertisementViewsList;
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
        public IResponseDTO GetByIDAdvertisementView(object id)
        {
            try
            {
                var AdvertisementViews = _AdvertisementViewRepositroy.Find(id);


                var AdvertisementViewsList = _mapper.Map<AdvertisementViewVM>(AdvertisementViews);
                _response.Data = AdvertisementViewsList;
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
        public IResponseDTO PostAdvertisementView(AdvertisementViewVM model)
        {

            try
            {
                var DbAdvertisementView = _mapper.Map<AdvertisementView>(model);

                var AdvertisementView = _mapper.Map<AdvertisementViewVM>(_AdvertisementViewRepositroy.Add(DbAdvertisementView));

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
