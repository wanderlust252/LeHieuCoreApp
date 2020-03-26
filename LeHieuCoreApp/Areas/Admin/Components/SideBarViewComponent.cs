using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LeHieuCoreApp.Application.Interfaces;
using LeHieuCoreApp.Application.ViewModels.System;
using LeHieuCoreApp.Extensions;
using LeHieuCoreApp.Utilities.Constants;

namespace LeHieuCoreApp.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {

        IFunctionService _functionService;
        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> functions;
            if (roles.Split(";").Contains(CommonConstants.AdminRole))
            {
                functions = await _functionService.GetAll();
            }
            else
            {
                functions = new List<FunctionViewModel>();
            }
            return View(functions);
        }
    }
}