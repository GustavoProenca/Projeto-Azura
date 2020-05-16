using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azura.Controllers
{
    public class BeneficiadoController : Controller
    {
        // GET: Beneficiado


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrados()
        {
            return View();
        }


    }
}