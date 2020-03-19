//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesMarket
    {
        IResponseDTO PostMarket(MarketVM model);
        IResponseDTO GetAllMarket();
        IResponseDTO EditMarket(MarketVM model);
        IResponseDTO DeleteMarket(MarketVM model);
        IResponseDTO GetByIDMarket(object id);
        IResponseDTO UpdateMarketToken(DTO.MarketTokenDTO marketToken);
        IResponseDTO MarketLogin(DTO.MarketLoginDTO marketlogin);
    }
}
