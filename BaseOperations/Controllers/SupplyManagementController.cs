﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BaseOperations.Controllers
{
    public class SupplyManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}