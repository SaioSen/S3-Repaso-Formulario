﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using S3_Repaso_Formulario.Models;

namespace S3_Repaso_Formulario.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SolicitudAdopcion()
        {
            return View();
        }

        //Redirect
        [HttpPost]
        public IActionResult SolicitudAdopcion(SolicitudAdopcion sa)
        {
            if(ModelState.IsValid){
                //guardar el objeto sa en la BD
                return RedirectToAction("Index");
            }
            return View(sa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
