//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesContactUsMarket
    {
        IResponseDTO PostContactUsMarket(ContactUsMarketVM model);
        IResponseDTO GetAllContactUsMarket();
        IResponseDTO EditContactUsMarket(ContactUsMarketVM model);
        IResponseDTO DeleteContactUsMarket(ContactUsMarketVM model);
        IResponseDTO GetByIDContactUsMarket(object id);
    }
}
