using AutoMapper;
//using BackEnd.DAL.Entities;
using BackEnd.DAL.Models;
using BackEnd.DAL.Views;
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

            CreateMap<AboutUsVM, AboutUs>().ReverseMap();
            CreateMap<AdvertisementOpenVM, AdvertisementOpen>().ReverseMap();
            CreateMap<AdminUsersVM, AdminUsers>().ReverseMap();
            CreateMap<AdvertisementUpdateVM, AdvertisementUpdate>().ReverseMap();
            CreateMap<AdvertisementViewVM, AdvertisementView>().ReverseMap();
            CreateMap<AdvertisementVM2, Advertisement>().ReverseMap();
            CreateMap<AdvertisementVM, Advertisement>().ReverseMap();
            CreateMap<CategoryVM, Category>().ReverseMap();
            CreateMap<CityVM, City>().ReverseMap();
            CreateMap<ContactUsVM, ContactUs>().ReverseMap();
            CreateMap<ContactUsMarketVM, ContactUsMarket>().ReverseMap();
            CreateMap<CountryVM, Country>().ReverseMap();
            CreateMap<CustomerLoginVM, CustomerLogin>().ReverseMap();
            CreateMap<CustomerVM, Customer>().ReverseMap();
            CreateMap<MarketFollowVM, MarketFollow>().ReverseMap();
            CreateMap<MarketVM, Market>().ReverseMap();
            CreateMap<MarketVM2, Market>().ReverseMap();
            CreateMap<PrivacyVM, Privacy>().ReverseMap();
            CreateMap<View_City, CityVM>();
            CreateMap<View_Advertisement, AdvertisementVM>();
            CreateMap<CityVM, View_City>().ForSourceMember(t => t.CountryName, opt => opt.DoNotValidate());
            CreateMap<AdvertisementVM, View_Advertisement>().ForSourceMember(t => t.CityName, opt => opt.DoNotValidate());
            CreateMap<AdvertisementVM, View_Advertisement>().ForSourceMember(t => t.CategoryName, opt => opt.DoNotValidate());
            CreateMap<AdvertisementVM, View_Advertisement>().ForSourceMember(t => t.MarketName, opt => opt.DoNotValidate());
               


            #endregion


        }
    }
}
