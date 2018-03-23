using MyPark.Model.DataBase;
using MyPark.Model.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPark.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var users = DbFactory.Instance.UserRepository.FindAll();

            if (users.Count <= 0)
            {
                var operador = new Operador()
                {
                    DtAdminissao = DateTime.Now,
                    Inativo = false,
                    Nome = "Administrador",
                    Usuario = new User()
                    {
                        Login = "admin",
                        Senha = "admin"
                    }
                };

                operador = DbFactory.Instance.OperadorRepository.Save(operador);
            }

            return View();
        }
    }
}