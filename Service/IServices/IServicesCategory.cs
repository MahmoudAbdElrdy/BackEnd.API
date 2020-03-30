//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesCategory
    {
        IResponseDTO PostCategory(CategoryVM model);
        IResponseDTO GetAllCategory();
        IResponseDTO EditCategory(CategoryVM model);
        IResponseDTO DeleteCategory(CategoryVM model);
        IResponseDTO GetByIDCategory(object id);
        IResponseDTO GetCategorysAds(Guid CustomerId);
    }
}
