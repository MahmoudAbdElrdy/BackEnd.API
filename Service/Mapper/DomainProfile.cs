﻿using AutoMapper;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            #region Secrity
            CreateMap<ApplicationUser, IdentityUser>().ReverseMap();
            //CreateMap<ApplicationUser, UserDetailsDto>().ReverseMap();
            #endregion


            //CreateMap<ReportSetting, ReportSettingModel>();
            //CreateMap<ReportSettingModel, ReportSetting>()
            //     .ForMember(t => t.CurrentDate, opt => opt.MapFrom(s => DateTime.ParseExact(s.CurrentDate, "d/M/yyyy", CultureInfo.InvariantCulture)));
            //#endregion

        }
    }
}