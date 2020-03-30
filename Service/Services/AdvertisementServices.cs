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
    public class AdvertisementServices : IServicesAdvertisement
    {
        private readonly IGRepository<Advertisement> _AdvertisementRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IGRepository<AdvertisementView> _AdvertisementViewRepositroy;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public AdvertisementServices(IGRepository<Advertisement> Advertisement, IGRepository<AdvertisementView> AdvertisementView,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _AdvertisementRepositroy = Advertisement;
            _AdvertisementViewRepositroy = AdvertisementView;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteAdvertisement(AdvertisementVM model)
        {
            try
            {

                var DbAdvertisement = _mapper.Map<Advertisement>(model);
                var entityEntry = _AdvertisementRepositroy.Remove(DbAdvertisement);


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
        public IResponseDTO EditAdvertisement(AdvertisementVM model)
        {
            try
            {
                var DbAdvertisement = _mapper.Map<Advertisement>(model);
                var entityEntry = _AdvertisementRepositroy.Update(DbAdvertisement);


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
        public IResponseDTO GetAdvertisementByCategory(int page,Guid categoryId, Guid cityId,Guid CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.CategoryId == categoryId && x.CityId == cityId)
                                                             .Skip(paging.skip).Take(paging.pageSize);
                foreach (var add in Advertisements)
                {
                    _AdvertisementViewRepositroy.Add(new AdvertisementView()
                    {
                        AdsViewId = Guid.NewGuid(),
                        AdsId = add.AdsId,
                        CustomerId = CustomerId,
                    });
                }

                var AdvertisementsList = _mapper.Map<List<AdvertisementVM>>(Advertisements);
                _response.Data = AdvertisementsList;
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
        public IResponseDTO GetAdvertisementByMarketId(int page,Guid marketId, Guid? CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.MarketId == marketId)
                                                             .Skip(paging.skip).Take(paging.pageSize);
                if (CustomerId != null && CustomerId != Guid.Empty)
                {
                    foreach (var add in Advertisements)
                    {
                        _AdvertisementViewRepositroy.Add(new AdvertisementView()
                        {
                            AdsViewId = Guid.NewGuid(),
                            AdsId = add.AdsId,
                            CustomerId = (Guid)CustomerId,
                        });
                    }
                }
                var AdvertisementsList = _mapper.Map<List<AdvertisementVM>>(Advertisements);
                _response.Data = AdvertisementsList;
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
        public IResponseDTO GetAdvertisementByCityId(int page,Guid cityId, Guid CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.CityId == cityId)
                                                             .Skip(paging.skip).Take(paging.pageSize);
                foreach (var add in Advertisements)
                {
                    _AdvertisementViewRepositroy.Add(new AdvertisementView()
                    {
                        AdsViewId = Guid.NewGuid(),
                        AdsId = add.AdsId,
                        CustomerId = CustomerId,
                    });
                }

                var AdvertisementsList = _mapper.Map<List<AdvertisementVM>>(Advertisements);
                _response.Data = AdvertisementsList;
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
        public IResponseDTO GetAllAdvertisement()
        {
            try
            {
                var Advertisements = _AdvertisementRepositroy.GetAll();


                var AdvertisementsList = _mapper.Map<List<AdvertisementVM>>(Advertisements);
                _response.Data = AdvertisementsList;
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
        public IResponseDTO GetNewAdvertisement(int page, Guid CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var Advertisements = _AdvertisementRepositroy.GetAll().OrderBy(x => x.StartDate)
                                                             .Skip(paging.skip).Take(paging.pageSize);
                foreach (var add in Advertisements)
                {
                    _AdvertisementViewRepositroy.Add(new AdvertisementView()
                    {
                        AdsViewId = Guid.NewGuid(),
                        AdsId = add.AdsId,
                        CustomerId = CustomerId,
                    });
                }
                var AdvertisementsList = _mapper.Map<List<AdvertisementVM>>(Advertisements);
                _response.Data = AdvertisementsList;
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
        public IResponseDTO GetByIDAdvertisement(object id)
        {
            try
            {
                var Advertisements = _AdvertisementRepositroy.Find(id);


                var AdvertisementsList = _mapper.Map<AdvertisementVM>(Advertisements);
                _response.Data = AdvertisementsList;
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
        public IResponseDTO PostAdvertisement(AdvertisementVM model)
        {

            try
            {
                var DbAdvertisement = _mapper.Map<Advertisement>(model);

                var Advertisement = _mapper.Map<AdvertisementVM>(_AdvertisementRepositroy.Add(DbAdvertisement));

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
