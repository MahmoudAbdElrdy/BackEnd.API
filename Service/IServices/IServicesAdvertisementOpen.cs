//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesAdvertisementOpen
    {
        IResponseDTO PostAdvertisementOpen(AdvertisementOpenVM model);
        IResponseDTO GetAllAdvertisementOpen();
        IResponseDTO EditAdvertisementOpen(AdvertisementOpenVM model);
        IResponseDTO DeleteAdvertisementOpen(AdvertisementOpenVM model);
        IResponseDTO GetByIDAdvertisementOpen(object id);
    }
}
