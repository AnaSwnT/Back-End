using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _16_ProjetoMVC.Views.Exercícios
{
    public class ExercíciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Exercício2()
        {
            return View();
        }

    }
}