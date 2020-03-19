//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesMarketFollow
    {
        IResponseDTO PostMarketFollow(MarketFollowVM model);
        IResponseDTO GetAllMarketFollow();
        IResponseDTO EditMarketFollow(MarketFollowVM model);
        IResponseDTO DeleteMarketFollow(MarketFollowVM model);
        IResponseDTO GetByIDMarketFollow(object id);
        IResponseDTO CustomerMarketFollow(DTO.MarketFollowDTO model);
    }
}
