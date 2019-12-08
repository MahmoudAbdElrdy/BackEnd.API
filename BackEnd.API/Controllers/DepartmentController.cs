using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Service.IServices;
using BackEnd.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentServices _departmentServices;
        public DepartmentController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;

        }
        [HttpPost]
        [Route("Department")]
        public IResponseDTO postDepartment(DepartmentModel departmentModel)
        {
            var depart = _departmentServices.PostDepartment(departmentModel);
            return depart;
        }
        [HttpPut]
        [Route("UpdateDepartment")]
        public IResponseDTO UpdateDepartment(DepartmentModel departmentModel)
        {
            var depart = _departmentServices.EditDepartment(departmentModel);
            return depart;
        }
        [HttpGet]
        [Route("GetAllDepartment")]
        public IResponseDTO GetAllDepartment()
        {
            var depart = _departmentServices.GetAllDepartment();
            return depart;
        }
        [HttpDelete]
        [Route("RemoveDepartment")]
        public IResponseDTO RemoveDepartment(DepartmentModel departmentModel)
        {
            var depart = _departmentServices.DeleteDepartment(departmentModel);
            return depart;
        }
    }
}