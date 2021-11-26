using Aplication.BusinessLogic.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FNT_WebAppFisionterapia.Controllers
{
    public class LoginController : Controller
    {
        private readonly IDepartamentoBusinessLogic _oIDepartamentoBusinessLogic;
        public LoginController(IDepartamentoBusinessLogic oIDepartamentoBusinessLogic)
        {
            this._oIDepartamentoBusinessLogic = oIDepartamentoBusinessLogic;
        }

        public IActionResult Index()
        {
            //var _resultado = _oIDepartamentoBusinessLogic.CargaDepartamento();

            return View();
        }


    }
}
