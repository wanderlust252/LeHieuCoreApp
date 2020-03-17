using AutoMapper;
using LeHieuCoreApp.Application.ViewModels.Product;
using LeHieuCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
