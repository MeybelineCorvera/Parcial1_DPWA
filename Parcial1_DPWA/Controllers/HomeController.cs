using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Parcial1_DPWA.Db;
using Parcial1_DPWA.Models;

namespace Parcial1_DPWA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext _dbContext)
        {
            _logger = logger;
            appDbContext = _dbContext;
        }

        public IActionResult Index()
        {
            Faculties faculties1 = new("Arquitectura e Ingenieria", "ArquitecturaIngenieria@univo.com", "La FIA de la UNIVO ofrece una formación en ingeniería y arquitectura. La carrera de Arquitectura dura 5 años y consta de 50 asignaturas. ", 8);
            faculties1.ToggleStatus();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
