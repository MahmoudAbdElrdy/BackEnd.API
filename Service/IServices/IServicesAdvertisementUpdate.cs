//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesAdvertisementUpdate
    {
        IResponseDTO PostAdvertisementUpdate(AdvertisementUpdateVM model);
        IResponseDTO GetAllAdvertisementUpdate();
        IResponseDTO EditAdvertisementUpdate(AdvertisementUpdateVM model);
        IResponseDTO DeleteAdvertisementUpdate(AdvertisementUpdateVM model);
        IResponseDTO GetByIDAdvertisementUpdate(object id);
        IResponseDTO WaitingUpdate(Guid? id);
    }
}
