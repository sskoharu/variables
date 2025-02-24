using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using variables.Models;


namespace variables.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string cedula, string nombre, string apellido, int edad)
        {
            List<ClienteModel> _listaCliente = new List<ClienteModel>();
                var cliente = new ClienteModel
                {
                    Apellido = apellido,
                    Cedula_RUC = cedula,
                    Direccion = "Ambato",
                    Edad = edad,
                    Genero = true,
                    Nombre = nombre,
                    Telefono = "098765432",
                    Id = 1
                };
                _listaCliente.Add(cliente);
            return View(_listaCliente);
        }

        public IActionResult Privacy(string cedula, string nombre, string apellido, int edad)
        {
            var cliente = new ClienteModel
            {
                Cedula_RUC = cedula,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad
            };

            return View(cliente);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
