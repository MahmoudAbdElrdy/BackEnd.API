﻿using AutoMapper;
//using BackEnd.DAL.Entities;
using BackEnd.DAL.Models;
using BackEnd.Repositories.Generics;
using BackEnd.Repositories.UOW;
using BackEnd.Service.IServices;
using BackEnd.Service.Models;
//using DAL;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Service.Services
{
    public class MarketServices : IServicesMarket
    {
        private readonly IGRepository<Market> _MarketRepositroy;
        private readonly IUnitOfWork<LoGooContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public MarketServices(IGRepository<Market> Market,
            IUnitOfWork<LoGooContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _MarketRepositroy = Market;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteMarket(MarketVM model)
        {
            try
            {

                var DbMarket = _mapper.Map<Market>(model);
                var entityEntry = _MarketRepositroy.Remove(DbMarket);


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

        public IResponseDTO EditMarket(MarketVM model)
        {
            try
            {
                var DbMarket = _mapper.Map<Market>(model);
                var entityEntry = _MarketRepositroy.Update(DbMarket);


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

        public IResponseDTO GetAllMarket()
        {
            try
            {
                var Markets = _MarketRepositroy.GetAll();


                var MarketsList = _mapper.Map<List<MarketVM>>(Markets);
                _response.Data = MarketsList;
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
        public IResponseDTO GetByIDMarket(object id)
        {
            try
            {
                var Markets = _MarketRepositroy.Find(id);


                var MarketsList = _mapper.Map<MarketVM>(Markets);
                _response.Data = MarketsList;
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
        public IResponseDTO PostMarket(MarketVM model)
        {

            try
            {
                var DbMarket = _mapper.Map<Market>(model);

                var Market = _mapper.Map<MarketVM>(_MarketRepositroy.Add(DbMarket));

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
