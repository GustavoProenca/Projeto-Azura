using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azura.Controllers
{
    public class DoadorController : Controller
    {
        // GET: Doador
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}