﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresService _vendedoresService;

        public VendedoresController(VendedoresService vendedoresService)
        {
            _vendedoresService = vendedoresService;
        }

        public IActionResult Index()
        {
            var lista = _vendedoresService.FindAll();
            return View(lista);
        }
    }
}