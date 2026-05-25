using Microsoft.AspNetCore.Mvc;

namespace PrototipoMVC_SanJuan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => RedirectToAction("Login");

        public IActionResult Login() => View();

        public IActionResult Dashboard() => View();

        public IActionResult Ventas() => View();

        public IActionResult Compras() => View();

        public IActionResult BodegaMovil() => View();

        public IActionResult GerenciaBI() => View();

        public IActionResult Marketing() => View();

        public IActionResult Administracion() => View();

        public IActionResult SupervisorBodega() => View();

        public IActionResult Contabilidad() => View();

        public IActionResult Reportes() => View();

        public IActionResult DetalleLote() => View();

        public IActionResult Alertas() => View();

        public IActionResult SupervisorPlanta() => View();
    }
}