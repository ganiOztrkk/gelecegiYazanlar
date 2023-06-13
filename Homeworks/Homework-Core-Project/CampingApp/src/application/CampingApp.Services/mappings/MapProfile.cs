using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CampingApp.DataTransferObjects.requests;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Entities;

namespace CampingApp.Services.mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDisplayResponseDto>();
            CreateMap<Category, CategoryDisplayResponseDto>();
            CreateMap<CreateNewProductRequestDto, Product>();
            CreateMap<UpdateProductRequestDto, Product>().ReverseMap();
            CreateMap<User, UsersDisplayResponseDto>().ReverseMap();
            CreateMap<UpdateUserRequestDto, User>().ReverseMap();
            CreateMap<CreateNewUserRequestDto, User>();
        }
    }
}
