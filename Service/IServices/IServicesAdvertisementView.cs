//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesAdvertisementView
    {
        IResponseDTO PostAdvertisementView(AdvertisementViewVM model);
        IResponseDTO GetAllAdvertisementView();
        IResponseDTO EditAdvertisementView(AdvertisementViewVM model);
        IResponseDTO DeleteAdvertisementView(AdvertisementViewVM model);
        IResponseDTO GetByIDAdvertisementView(object id);
    }
}
