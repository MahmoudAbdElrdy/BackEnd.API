//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesPrivacy
    {
        IResponseDTO PostPrivacy(PrivacyVM model);
        IResponseDTO GetAllPrivacy();
        IResponseDTO EditPrivacy(PrivacyVM model);
        IResponseDTO DeletePrivacy(PrivacyVM model);
        IResponseDTO GetByIDPrivacy(object id);
    }
}
