//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesAboutUs
    {
        IResponseDTO PostAboutUs(AboutUsVM model);
        IResponseDTO GetAllAboutUs();
        IResponseDTO EditAboutUs(AboutUsVM model);
        IResponseDTO DeleteAboutUs(AboutUsVM model);
        IResponseDTO GetByIDAboutUs(object id);
        IResponseDTO GetAboutUs();
    }
}
