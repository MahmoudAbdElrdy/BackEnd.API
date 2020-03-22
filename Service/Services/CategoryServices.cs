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
    public class CategoryServices : IServicesCategory
    {
        private readonly IGRepository<Category> _CategoryRepositroy;
        private readonly IGRepository<Advertisement> _AdvertisementRepositroy;
        private readonly IUnitOfWork<DB_A56457_LookandGoContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public CategoryServices(IGRepository<Category> Category,IGRepository<Advertisement> Advertisement,
            IUnitOfWork<DB_A56457_LookandGoContext> unitOfWork, IResponseDTO responseDTO, IMapper mapper)
        {
            _CategoryRepositroy = Category;
            _AdvertisementRepositroy = Advertisement;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteCategory(CategoryVM model)
        {
            try
            {
                var DbCategory = _mapper.Map<Category>(model);
                var entityEntry = _CategoryRepositroy.Remove(DbCategory);

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
        public IResponseDTO EditCategory(CategoryVM model)
        {
            try
            {
                var DbCategory = _mapper.Map<Category>(model);
                var entityEntry = _CategoryRepositroy.Update(DbCategory);
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
        public IResponseDTO GetAllCategory()
        {
            try
            {
                var Categorys = _CategoryRepositroy.GetAll();

                var CategorysList = _mapper.Map<List<CategoryVM>>(Categorys);
                _response.Data = CategorysList;
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
        public IResponseDTO GetByIDCategory(object id)
        {
            try
            {
                var Categorys = _CategoryRepositroy.Find(id);

                var CategorysList = _mapper.Map<CategoryVM>(Categorys);
                _response.Data = CategorysList;
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
        public IResponseDTO GetCategorysAds()
        {
            try
            {
                var Categorys = _CategoryRepositroy.GetAll();
                var ads = _AdvertisementRepositroy.Get(x => x.Special == true);
                var CategorysList = _mapper.Map<List<CategoryVM>>(Categorys);
                var adsList = _mapper.Map<List<AdvertisementVM>>(ads);

                _response.Data = new DTO.AdsCategryDTO()
                {
                    category = CategorysList,
                    ads = adsList,
                };
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
        public IResponseDTO PostCategory(CategoryVM model)
        {
            try
            {
                var DbCategory = _mapper.Map<Category>(model);
                var Category = _mapper.Map<CategoryVM>(_CategoryRepositroy.Add(DbCategory));
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
