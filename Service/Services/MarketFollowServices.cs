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
    public class MarketFollowServices : IServicesMarketFollow
    {
        private readonly IGRepository<MarketFollow> _MarketFollowRepositroy;
        private readonly IUnitOfWork<LoGooContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public MarketFollowServices(IGRepository<MarketFollow> MarketFollow,
            IUnitOfWork<LoGooContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _MarketFollowRepositroy = MarketFollow;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteMarketFollow(MarketFollowVM model)
        {
            try
            {

                var DbMarketFollow = _mapper.Map<MarketFollow>(model);
                var entityEntry = _MarketFollowRepositroy.Remove(DbMarketFollow);


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

        public IResponseDTO EditMarketFollow(MarketFollowVM model)
        {
            try
            {
                var DbMarketFollow = _mapper.Map<MarketFollow>(model);
                var entityEntry = _MarketFollowRepositroy.Update(DbMarketFollow);


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

        public IResponseDTO GetAllMarketFollow()
        {
            try
            {
                var MarketFollows = _MarketFollowRepositroy.GetAll();


                var MarketFollowsList = _mapper.Map<List<MarketFollowVM>>(MarketFollows);
                _response.Data = MarketFollowsList;
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
        public IResponseDTO GetByIDMarketFollow(object id)
        {
            try
            {
                var MarketFollows = _MarketFollowRepositroy.Find(id);


                var MarketFollowsList = _mapper.Map<MarketFollowVM>(MarketFollows);
                _response.Data = MarketFollowsList;
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
        public IResponseDTO PostMarketFollow(MarketFollowVM model)
        {

            try
            {
                var DbMarketFollow = _mapper.Map<MarketFollow>(model);

                var MarketFollow = _mapper.Map<MarketFollowVM>(_MarketFollowRepositroy.Add(DbMarketFollow));

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
        public IResponseDTO CustomerMarketFollow(DTO.MarketFollowDTO model)
        {
            try
            {
                var currentFollow = _MarketFollowRepositroy.GetFirst(x => x.Customerid == model.Customerid && x.Marketid == model.Marketid);
                if (currentFollow != null) 
                {
                    currentFollow.Follow = model.Follow;
                    var entityEntry = _MarketFollowRepositroy.Update(currentFollow);
                }
                else
                {
                    var Follow = new MarketFollowVM()
                    {
                        //MarketCustomerId = Guid.NewGuid(),
                        CreationDate = DateTime.UtcNow.AddHours(3),
                        Marketid = model.Marketid,
                        Follow = model.Follow,
                        Customerid = model.Customerid,
                    };
                    var DbMarketFollow = _mapper.Map<MarketFollow>(model);

                    var MarketFollow = _mapper.Map<MarketFollowVM>(_MarketFollowRepositroy.Add(DbMarketFollow));
                }
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
