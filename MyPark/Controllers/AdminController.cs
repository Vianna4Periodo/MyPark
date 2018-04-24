using MyPark.Model.DataBase;
using MyPark.Model.DataBase.Models;
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
            var tipoVeiculos = DbFactory.Instance.TipoVeiculoRepository.FindAll();
            return View(tipoVeiculos);
        }

        public ActionResult AddTipoVeiculo()
        {
            return View(new TipoVeiculo());
        }

        public PartialViewResult GravarTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            DbFactory.Instance.TipoVeiculoRepository.SaveOrUpdate(tipoVeiculo);
            return PartialView("_TabelaTipoVeiculo", DbFactory.Instance.TipoVeiculoRepository.FindAll());
        }
    }
}