using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProdutos1.Models;
using System.Web.Mvc;

namespace WebProdutos1.Controllers
{
    public class HomeController : Controller
    {
        // **********  CONTROLLER PRODUTOS  ***********

        public ActionResult Index()
        {
            var produto = new Product(); //objeto da classe

            return View(produto); //dados da classe
        }
        [HttpPost]
        public ActionResult Index(Product produto)
        {
            if (ModelState.IsValid) //validação do estado
            {
                return View("Resultado", produto); //resultado retornando a View
            }
            return View(produto);

        }

        public ActionResult Resultado(Product produto) //ação para a View Resultado
        {
            return View(produto);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}