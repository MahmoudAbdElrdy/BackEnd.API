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
        IResponseDTO PostAdvertisement(AdvertisementIncloudVM model);
        IResponseDTO PostAdvertisementAttach(AdvertisementAttachVM model);
        IResponseDTO PostAdvertisementCategory(AdvertisementCategoryVM model);
        IResponseDTO PostAdvertisementCity(AdvertisementCityVM model);
        IResponseDTO GetAllAdvertisement();
        IResponseDTO GetNewAdvertisement(int page, Guid CustomerId);
        IResponseDTO EditAdvertisement(AdvertisementIncloudVM model);
        IResponseDTO DeleteAdvertisementCity(AdvertisementCityVM model);
        IResponseDTO DeleteAdvertisementAttach(AdvertisementAttachVM model);
        IResponseDTO DeleteAdvertisementCategory(AdvertisementCategoryVM model);
        IResponseDTO DeleteAdvertisement(AdvertisementVM model);
        IResponseDTO GetByIDAdvertisement(object id);
        IResponseDTO GetAdvertisementDetails(Guid id, Guid CustomerId);
        IResponseDTO GetAdvertisementByCityId(int page, Guid cityId, Guid CustomerId);
        IResponseDTO GetAdvertisementByMarketId(int page, Guid marketId, Guid? CustomerId);
        IResponseDTO GetAdvertisementByCategory(int page, Guid categoryId, Guid cityId, Guid CustomerId);
        IResponseDTO GetAdvertisementByCategoryForAllCity(int page, Guid categoryId, Guid CustomerId);
        IResponseDTO GetAllAdvertisementSTP();
    }
}
