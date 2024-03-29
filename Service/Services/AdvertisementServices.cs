﻿using AutoMapper;
using BackEnd.DAL.Models;
using BackEnd.DAL.Views;
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
        #region privateFilde
        private readonly IGRepository<Advertisement> _AdvertisementRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IGRepository<AdvertisementView> _AdvertisementViewRepositroy;
        private readonly IGRepository<AdvertisementOpen> _AdvertisementOpenRepositroy;
        private readonly IGRepository<AdvertisementAttach> _AdvertisementAttachRepositroy;
        private readonly IGRepository<AdvertisementCategory> _AdvertisementCategoryRepositroy;
        private readonly IGRepository<AdvertisementCity> _AdvertisementCityRepositroy;
        private readonly IGRepository<View_Advertisement> _View_AdvertisementRepositroy;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        #endregion

        #region AdvertisementServices
        public AdvertisementServices(IGRepository<Advertisement> Advertisement
            , IGRepository<AdvertisementView> AdvertisementView
            , IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork
            , IResponseDTO responseDTO, IMapper mapper
            , IGRepository<View_Advertisement> View_AdvertisementRepositroy
            , IGRepository<AdvertisementOpen> AdvertisementOpen
            , IGRepository<AdvertisementAttach> AdvertisementAttach
            , IGRepository<AdvertisementCategory> AdvertisementCategory
            , IGRepository<AdvertisementCity> AdvertisementCity)
        {
            _AdvertisementRepositroy = Advertisement;
            _AdvertisementViewRepositroy = AdvertisementView;
            _AdvertisementOpenRepositroy = AdvertisementOpen;
            _AdvertisementAttachRepositroy = AdvertisementAttach;
            _AdvertisementCategoryRepositroy = AdvertisementCategory;
            _AdvertisementCityRepositroy = AdvertisementCity;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;
            _View_AdvertisementRepositroy = View_AdvertisementRepositroy;

        }
        #endregion

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
        public IResponseDTO DeleteAdvertisementAttach(AdvertisementAttachVM model)
        {
            try
            {

                var DbAdvertisementAttach = _mapper.Map<AdvertisementAttach>(model);
                var entityEntry = _AdvertisementAttachRepositroy.Remove(DbAdvertisementAttach);


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
        public IResponseDTO DeleteAdvertisementCity(AdvertisementCityVM model)
        {
            try
            {

                var DbAdvertisementAttach = _mapper.Map<AdvertisementCity>(model);
                var entityEntry = _AdvertisementCityRepositroy.Remove(DbAdvertisementAttach);


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
        public IResponseDTO DeleteAdvertisementCategory(AdvertisementCategoryVM model)
        {
            try
            {

                var DbAdvertisementAttach = _mapper.Map<AdvertisementCategory>(model);
                var entityEntry = _AdvertisementCategoryRepositroy.Remove(DbAdvertisementAttach);


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
        public IResponseDTO EditAdvertisement(AdvertisementIncloudVM model)
        {
            try
            {
                var _AdvertisementCategory = model.AdvertisementCategory?.ToList();
                var _AdvertisementCity = model.AdvertisementCity?.ToList();
                model.AdvertisementCategory = null;
                model.AdvertisementCity = null;
                var DbAdvertisement = _mapper.Map<Advertisement>(model);
                var entityEntry = _AdvertisementRepositroy.Update(DbAdvertisement);
                var _ACategory = _AdvertisementCategoryRepositroy.Get(x => x.AdsId == model.AdsId).ToList();
                if (_ACategory != null && _ACategory.Count > 0)
                {
                    _AdvertisementCategoryRepositroy.RemoveRange(_ACategory);
                }
                if (_AdvertisementCategory != null && _AdvertisementCategory.Count > 0) 
                {
                    _AdvertisementCategory.ForEach(x => x.AdsId = model.AdsId);
                    _AdvertisementCategoryRepositroy.AddRange(_mapper.Map<List<AdvertisementCategory>>(_AdvertisementCategory));
                }
                var _ACity = _AdvertisementCityRepositroy.Get(x => x.AdsId == model.AdsId).ToList();
                if (_ACity != null && _ACity.Count > 0)
                {
                    _AdvertisementCityRepositroy.RemoveRange(_ACity);
                }
                if (_AdvertisementCity != null && _AdvertisementCity.Count > 0)
                {
                    _AdvertisementCity.ForEach(x => x.AdsId = model.AdsId);
                    _AdvertisementCityRepositroy.AddRange(_mapper.Map<List<AdvertisementCity>>(_AdvertisementCity));
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
        public IResponseDTO GetAdvertisementByCategory(int page,Guid categoryId, Guid cityId,Guid CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var date = DateTime.Now.Date;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.Available == true
                                    && x.StartDate <= date.AddDays(1) && x.EndDate >= date.AddDays(-1)
                                    && x.AdvertisementCategory.Any(y => y.CategoryId == categoryId)
                                    && x.AdvertisementCity.Any(y => y.CityId == cityId),
                                    includeProperties: "Market,AdvertisementCity,AdvertisementCategory")
                                    .Skip(paging.skip).Take(paging.pageSize);
                var AdvertisementsList = new List<AdvertisementVM2>();
                foreach (var add in Advertisements)
                {
                    _AdvertisementViewRepositroy.Add(new AdvertisementView()
                    {
                        AdsViewId = Guid.NewGuid(),
                        AdsId = add.AdsId,
                        CustomerId = CustomerId,
                    });
                    AdvertisementsList.Add(_mapper.Map<AdvertisementVM2>(add));
                }
                _unitOfWork.Commit();
                //var AdvertisementsList = _mapper.Map<List<AdvertisementVM2>>(Advertisements);
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
        public IResponseDTO GetAdvertisementByCategoryForAllCity(int page, Guid categoryId, Guid CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var date = DateTime.Now.Date;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.Available == true
                                    && x.StartDate <= date.AddDays(1) && x.EndDate >= date.AddDays(-1)
                                    && x.AdvertisementCategory.Any(y=> y.CategoryId == categoryId),
                                        includeProperties: "Market,AdvertisementCategory")
                                        .Skip(paging.skip).Take(paging.pageSize);
                var AdvertisementsList = new List<AdvertisementVM2>();
                foreach (var add in Advertisements)
                {
                    _AdvertisementViewRepositroy.Add(new AdvertisementView()
                    {
                        AdsViewId = Guid.NewGuid(),
                        AdsId = add.AdsId,
                        CustomerId = CustomerId,
                    });
                    AdvertisementsList.Add(_mapper.Map<AdvertisementVM2>(add));
                }
                _unitOfWork.Commit();
                //var AdvertisementsList = _mapper.Map<List<AdvertisementVM2>>(Advertisements);
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
                var Advertisements = _AdvertisementRepositroy.Get(x => x.MarketId == marketId, includeProperties: "Market")
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
                    _unitOfWork.Commit();
                }
                var AdvertisementsList = _mapper.Map<List<AdvertisementVM2>>(Advertisements);
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
                var date = DateTime.Now.Date;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.Available == true
                                     && x.StartDate <= date.AddDays(1) && x.EndDate >= date.AddDays(-1)
                                     && x.AdvertisementCity.Any(y => y.CityId == cityId),
                                                             includeProperties: "Market,AdvertisementCity")
                                                             .Skip(paging.skip).Take(paging.pageSize);
                var AdvertisementsList = new List<AdvertisementVM2>();
                foreach (var add in Advertisements)
                {
                    _AdvertisementViewRepositroy.Add(new AdvertisementView()
                    {
                        AdsViewId = Guid.NewGuid(),
                        AdsId = add.AdsId,
                        CustomerId = CustomerId,
                    });
                    AdvertisementsList.Add(_mapper.Map<AdvertisementVM2>(add));
                }
                _unitOfWork.Commit();
                //var AdvertisementsList = _mapper.Map<List<AdvertisementVM2>>(Advertisements);
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
                var Advertisements = _AdvertisementRepositroy.Get(includeProperties: "Market,AdvertisementCity,AdvertisementCity.City,AdvertisementCategory,AdvertisementAttach").OrderByDescending(x => x.CreationDate);
                
                //foreach(var model in Advertisements)
                //{
                //    model.Available = true;
                //    var DbAdvertisement = _mapper.Map<Advertisement>(model);
                //    var entityEntry = _AdvertisementRepositroy.Update(DbAdvertisement);
                //}
                //int save = _unitOfWork.Commit();
                var AdvertisementsList = _mapper.Map<List<AdvertisementIncloudVM>>(Advertisements);
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


        //public IResponseDTO GetAllAdvertisement()
        //{
        //    try
        //    {
        //        var Advertisements = _AdvertisementRepositroy.GetAll().OrderByDescending(x => x.CreationDate);

        //        foreach (var ads in Advertisements)
        //        {
        //            if (ads.CategoryId != null)
        //            {
        //                _AdvertisementCategoryRepositroy.Add(new AdvertisementCategory()
        //                {
        //                    AdsCategoryId = Guid.NewGuid(),
        //                    CategoryId = ads.CategoryId,
        //                    AdsId = ads.AdsId,
        //                    Available = true,
        //                    CreationDate = (DateTime)ads.CreationDate
        //                });
        //            }
        //            if (ads.CityId != null)
        //            {
        //                _AdvertisementCityRepositroy.Add(new AdvertisementCity()
        //                {
        //                    AdsCityId = Guid.NewGuid(),
        //                    CityId = ads.CityId,
        //                    AdsId = ads.AdsId,
        //                    Available = true,
        //                    CreationDate = (DateTime)ads.CreationDate
        //                });
        //            }
        //            if (!string.IsNullOrEmpty(ads.AdsImage))
        //            {
        //                _AdvertisementAttachRepositroy.Add(new AdvertisementAttach()
        //                {
        //                    AdsAttachId = Guid.NewGuid(),
        //                    AdsId = ads.AdsId,
        //                    Available = true,
        //                    CreationDate = (DateTime)ads.CreationDate,
        //                    AttachType = 0,
        //                    AttachUrl = ads.AdsImage,
        //                });
        //            }
        //            if (!string.IsNullOrEmpty(ads.AdsVideo))
        //            {
        //                _AdvertisementAttachRepositroy.Add(new AdvertisementAttach()
        //                {
        //                    AdsAttachId = Guid.NewGuid(),
        //                    AdsId = ads.AdsId,
        //                    Available = true,
        //                    CreationDate = (DateTime)ads.CreationDate,
        //                    AttachType = 1,
        //                    AttachUrl = ads.AdsVideo,
        //                });
        //            }
        //        }
        //        _unitOfWork.Commit();
        //        var AdvertisementsList = _mapper.Map<List<AdvertisementVM>>(Advertisements);
        //        _response.Data = AdvertisementsList;
        //        _response.IsPassed = true;
        //        _response.Message = "Done";
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.Data = null;
        //        _response.IsPassed = false;
        //        _response.Message = "Error " + ex.Message;
        //    }
        //    return _response;

        //}


        public IResponseDTO GetNewAdvertisement(int page, Guid CustomerId)
        {
            try
            {
                var paging = new DTO.Pageing();
                paging.pageNumber = page;
                var date = DateTime.Now.Date;
                var Advertisements = _AdvertisementRepositroy.Get(x => x.Available == true && x.Special == true
                                     && x.StartDate <= date.AddDays(1) && x.EndDate >= date.AddDays(-1)
                                    , includeProperties: "Market")
                                                             .OrderBy(x => x.StartDate)
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
                _unitOfWork.Commit();
                var AdvertisementsList = _mapper.Map<List<AdvertisementVM2>>(Advertisements);
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
        public IResponseDTO GetAdvertisementDetails(Guid id, Guid CustomerId)
        {
            try
            {
                var Advertisements = _AdvertisementRepositroy.Get(x=>x.AdsId == id,
                    includeProperties: "Market,AdvertisementCity,AdvertisementCity.City,AdvertisementCategory.Category,AdvertisementAttach").FirstOrDefault();
                if(Advertisements!= null)
                {
                    _AdvertisementOpenRepositroy.Add(new AdvertisementOpen()
                    {
                        AdsOpenId = Guid.NewGuid(),
                        AdsId = Advertisements.AdsId,
                        CustomerId = CustomerId,
                    });
                    _unitOfWork.Commit();
                }
                var AdvertisementsList = _mapper.Map<AdvertisementIncloudVM>(Advertisements);
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
        public IResponseDTO PostAdvertisement(AdvertisementIncloudVM model)
        {

            try
            {
                model.Available = true;
                var DbAdvertisement = _mapper.Map<Advertisement>(model);

                var Advertisement = _mapper.Map<AdvertisementIncloudVM>(_AdvertisementRepositroy.Add(DbAdvertisement));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = Advertisement;
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
        public IResponseDTO PostAdvertisementAttach(AdvertisementAttachVM model)
        {

            try
            {
                model.Available = true;
                var DbAdvertisement = _mapper.Map<AdvertisementAttach>(model);

                var Advertisement = _mapper.Map<AdvertisementAttachVM>(_AdvertisementAttachRepositroy.Add(DbAdvertisement));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = Advertisement;
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
        public IResponseDTO PostAdvertisementCategory(AdvertisementCategoryVM model)
        {

            try
            {
                model.Available = true;
                var DbAdvertisement = _mapper.Map<AdvertisementCategory>(model);

                var Advertisement = _mapper.Map<AdvertisementCategoryVM>(_AdvertisementCategoryRepositroy.Add(DbAdvertisement));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = Advertisement;
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
        public IResponseDTO PostAdvertisementCity(AdvertisementCityVM model)
        {

            try
            {
                model.Available = true;
                var DbAdvertisement = _mapper.Map<AdvertisementCity>(model);

                var Advertisement = _mapper.Map<AdvertisementCityVM>(_AdvertisementCityRepositroy.Add(DbAdvertisement));

                int save = _unitOfWork.Commit();

                if (save == 200)
                {
                    _response.Data = Advertisement;
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
        public IResponseDTO GetAllAdvertisementSTP()
        {
            try
            {
                var Citys = _View_AdvertisementRepositroy.ExecuteQueryView("SELECT * FROM [dbo].[View_Advertisement]", null).ToList();
                var CitysList = _mapper.Map<List<AdvertisementVM>>(Citys);
                _response.Data = CitysList;
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
     
    }
}
