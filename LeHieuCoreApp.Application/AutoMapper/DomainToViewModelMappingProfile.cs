using AutoMapper;
using LeHieuCoreApp.Application.ViewModels.Product;
using LeHieuCoreApp.Application.ViewModels.System;
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
            CreateMap<Function, FunctionViewModel>();
            CreateMap<Product, ProductViewModel>();

            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
            //CreateMap<Permission, PermissionViewModel>();
            CreateMap<PermissionViewModel, Permission>();
            CreateMap<Bill, BillViewModel>();
            CreateMap<BillDetail, BillDetailViewModel>();
            CreateMap<Color, ColorViewModel>();
            CreateMap<Size, SizeViewModel>();
            CreateMap<ProductQuantity, ProductQuantityViewModel>().MaxDepth(2);
        }
    }
}
