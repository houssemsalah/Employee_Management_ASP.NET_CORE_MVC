﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TP1_ASPNETCORE.Models;

namespace TP1_ASPNETCORE.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp e)
        {
            return View();
        }

    }
}