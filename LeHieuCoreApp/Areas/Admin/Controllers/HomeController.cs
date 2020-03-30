using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeHieuCoreApp.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LeHieuCoreApp.Areas.Admin.Controllers
{ 
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
    }
}