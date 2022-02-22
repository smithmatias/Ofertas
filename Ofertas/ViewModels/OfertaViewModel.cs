using Ofertas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ofertas.ViewModels
{
    public class OfertaViewModel
    {
        public Oferta Oferta { get; set; }

        public List<Producto> Productos { get; set; }

        public List<Proveedor> Proveedores { get; set; }
    }
}