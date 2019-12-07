using AutoMapper;
using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Repositories.UOW;
using BackEnd.Service.IServices;
using BackEnd.Service.Models;
using DAL;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Service.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IGRepository<Department> _departmentRepositroy;
        private readonly IUnitOfWork<DatabaseContext> _unitOfWork;
        private readonly IResponseDTO _response;
        private readonly IMapper _mapper;
        public DepartmentServices(IGRepository<Department> Department,
            IUnitOfWork<DatabaseContext> unitOfWork,IResponseDTO responseDTO, IMapper mapper)
        {
            _departmentRepositroy = Department;
            _unitOfWork = unitOfWork;
            _response = responseDTO;
            _mapper = mapper;

        }
        public IResponseDTO DeleteDepartment(DepartmentModel model)
        {
           // _unitOfWork.

            throw new NotImplementedException();
        }

        public IResponseDTO EditDepartment(DepartmentModel model)
        {
            throw new NotImplementedException();
        }

        public IResponseDTO GetDepartment()
        {
            throw new NotImplementedException();
        }

        public IResponseDTO PostDepartment(DepartmentModel model)
        {
           
            try
            {
                var DbDepartment = _mapper.Map<Department>(model);
              
                var Department = _mapper.Map<DepartmentModel>(_departmentRepositroy.Add(DbDepartment));

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
