using Microsoft.AspNetCore.Mvc;
using Parcial1_DPWA.Db;
using Parcial1_DPWA.Models;

namespace Parcial1_DPWA.Controllers
{
    public class FacultiesController : Controller
    {
        private readonly AppDbContext _dbConn;

        public FacultiesController(AppDbContext appDb)
        {
            _dbConn = appDb;
        }

        // Mostrar todas las facultades
        public IActionResult Index()
        {
            List<Faculties> faculties = _dbConn.Faculties.ToList();
            return View(faculties);
        }
    }
}
