using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPark.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult TipoVeiculo()
        {
            return View();
        }
    }
}