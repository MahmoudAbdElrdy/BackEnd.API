﻿using AutoMapper;
//using BackEnd.DAL.Entities;
using BackEnd.DAL.Models;
using BackEnd.Service.Models;
//using DAL.Entities;
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
            //#region Secrity
            //CreateMap<ApplicationUser, IdentityUser>().ReverseMap();

            //#endregion
            //CreateMap<Department, DepartmentModel>().ReverseMap();
            //CreateMap<Employee, EmployeeModel>().ReverseMap();

            //CreateMap<ReportSetting, ReportSettingModel>();
            //CreateMap<ReportSettingModel, ReportSetting>()
            //     .ForMember(t => t.CurrentDate, opt => opt.MapFrom(s => DateTime.ParseExact(s.CurrentDate, "d/M/yyyy", CultureInfo.InvariantCulture)));
            //#endregion
            #region ModelsAutoMapper

            CreateMap<AdvertisementOpenVM, AdvertisementOpen>().ReverseMap();
            CreateMap<AdvertisementUpdateVM, AdvertisementUpdate>().ReverseMap();
            CreateMap<AdvertisementViewVM, AdvertisementView>().ReverseMap();
            CreateMap<AdvertisementVM, Advertisement>().ReverseMap();
            CreateMap<CityVM, City>().ReverseMap();
            CreateMap<CountryVM, Country>().ReverseMap();
            CreateMap<CustomerLoginVM, CustomerLogin>().ReverseMap();
            CreateMap<CustomerVM, Customer>().ReverseMap();
            CreateMap<MarketFollowVM, MarketFollow>().ReverseMap();
            CreateMap<MarketVM, Market>().ReverseMap();
            
            #endregion


        }
    }
}
