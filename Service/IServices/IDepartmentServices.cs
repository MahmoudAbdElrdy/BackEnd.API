using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IDepartmentServices
    {
        IResponseDTO PostDepartment(DepartmentModel model);
        IResponseDTO GetAllDepartment();
        IResponseDTO EditDepartment(DepartmentModel model);
        IResponseDTO DeleteDepartment(DepartmentModel model);
    }
}
