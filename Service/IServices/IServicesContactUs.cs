//using BackEnd.DAL.Entities;
using BackEnd.Repositories.Generics;
using BackEnd.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.IServices
{
   public interface IServicesContactUs
    {
        IResponseDTO PostContactUs(ContactUsVM model);
        IResponseDTO GetAllContactUs();
        IResponseDTO EditContactUs(ContactUsVM model);
        IResponseDTO DeleteContactUs(ContactUsVM model);
        IResponseDTO GetByIDContactUs(object id);
    }
}
