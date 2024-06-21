using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebACT2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Menu");
        }
        public ActionResult IrVistaNombre()
        {
            return View("FormNombre");
        }
        public ActionResult IrVistaDireccion()
        {
            return View("FormDireccion");
        }
        public ActionResult RecibirNombre(string nombre, string apellP, string apellM, int edad)
        {
            string oracion = $"Mi nombre es: {nombre} {apellP} {apellM} y tengo {edad} años.";

            TempData["oracion"] = oracion;

            return View("FormNombre");
        }
        public ActionResult RecibirDireccion(string direccion, int cp, string colonia,string delegacion)
        {
            string oracion = $"Mi direccion es: {direccion}, {cp}, {colonia}, {delegacion}.";

            TempData["oracion"] = oracion;

            return View("ResultadoFormDireccion");
        }
    }
}