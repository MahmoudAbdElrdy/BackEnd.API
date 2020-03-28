﻿//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesAdvertisement
    {
        IResponseDTO PostAdvertisement(AdvertisementVM model);
        IResponseDTO GetAllAdvertisement();
        IResponseDTO GetNewAdvertisement(int page);
        IResponseDTO EditAdvertisement(AdvertisementVM model);
        IResponseDTO DeleteAdvertisement(AdvertisementVM model);
        IResponseDTO GetByIDAdvertisement(object id);
        IResponseDTO GetAdvertisementByCityId(int page, Guid cityId);
        IResponseDTO GetAdvertisementByMarketId(int page, Guid marketId);
        IResponseDTO GetAdvertisementByCategory(int page, Guid categoryId, Guid cityId);
    }
}
