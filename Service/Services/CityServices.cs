using AutoMapper;
//using BackEnd.DAL.Entities;
using BackEnd.DAL.Models;
using BackEnd.DAL.Views;
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
    public class CityServices : IServicesCity
    {
        private readonly IGRepository<City> _CityRepositroy;
        private readonly IGRepository<View_City> _View_CityRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public CityServices(IGRepository<City> City, IGRepository<View_City> View_CityRepositroy,
        IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork,IResponseDTO responseDTO, IMapper mapper)
        {
            _View_CityRepositroy = View_CityRepositroy;
               _CityRepositroy = City;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteCity(CityVM model)
        {
            try
            {
             
                var DbCity = _mapper.Map<City>(model);
                var entityEntry = _CityRepositroy.Remove(DbCity);


                int save = _unitOfWork.Commit();

                if (save ==200)
                {
                    _response.Data =null;
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

        public IResponseDTO EditCity(CityVM model)
        {
            try
            {
                var DbCity = _mapper.Map<City>(model);
                var entityEntry = _CityRepositroy.Update(DbCity);


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
        // Saudi id : 'fd3f74d2-f3ca-4f17-b3be-cdf6ef800f7a'
        public IResponseDTO GetSaudiCity()
        {
            try
            {
                var Citys = _CityRepositroy.Get(x => x.CountryId == Guid.Parse("fd3f74d2-f3ca-4f17-b3be-cdf6ef800f7a"))
                                           .OrderBy(y => y.Order).OrderBy(z => z.CityName).ToList();
                //Citys.ForEach(x => x.CityId = Guid.Parse("695314ee-5a98-40de-a8d2-50b0130c5a0c"));
                var CitysList = _mapper.Map<List<CityVM>>(Citys);
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
        public IResponseDTO GetAllCity()
        {
            try
            {
                var Citys = _CityRepositroy.GetAll();
                var CitysList = _mapper.Map<List<CityVM>>(Citys);
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
        public IResponseDTO GetAllCitySTP()
        {
            try
            {
                var Citys = _View_CityRepositroy.ExecuteQueryView("SELECT * FROM [dbo].[View_City]", null).ToList();
                var CitysList = _mapper.Map<List<CityVM>>(Citys);
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
        public IResponseDTO GetByIDCity(object id)
        {
            try
            {
                var Citys = _CityRepositroy.Find(id);

                var CitysList = _mapper.Map<CityVM>(Citys);
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
        public IResponseDTO PostCity(CityVM model)
        {
            try
            {
                var DbCity = _mapper.Map<City>(model);
              
                var City = _mapper.Map<CityVM>(_CityRepositroy.Add(DbCity));

                int save =  _unitOfWork.Commit();

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
