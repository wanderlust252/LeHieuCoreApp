﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeHieuCoreApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LeHieuCoreApp.Areas.Admin.Controllers
{
    public class RoleController : BaseController
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAll()
        {
            var model = await _roleService.GetAllAsync();

            return new OkObjectResult(model);
        }

    }
}