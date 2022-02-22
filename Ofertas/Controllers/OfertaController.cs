using Ofertas.Models;
using Ofertas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ofertas.Controllers
{
    public class OfertaController : Controller
    {
        // GET: Oferta
        public ActionResult Index()
        {
            return View();
        }

    public ActionResult Nuevo()
        {
            PromocionesConnection BD = new PromocionesConnection();
            OfertaViewModel viewModel = new OfertaViewModel();
            viewModel.Productos = BD.Productoes.ToList();
            viewModel.Proveedores = BD.Proveedors.ToList();


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Nuevo(OfertaViewModel model)
        {
            PromocionesConnection BD = new PromocionesConnection();
            BD.Ofertas.Add(model.Oferta);
            BD.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}