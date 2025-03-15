using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult UpSert(int id)
        {
            if (id == 0)
            {
                //REGISTRO NUEVO
                Faculties faculties = new();
                return View(faculties);
            }
            else
            {
                //REGISTRO EXISTENTE
                Faculties faculties = _dbConn.Faculties.FirstOrDefault(row => row.Id == id) ?? new();
                return View(faculties);
            }
        }
        [HttpPost]
        public IActionResult UpSert(Faculties model)
        {
            if (model.Id == 0)
            {
                if (ModelState.IsValid)
                {
                    _dbConn.Faculties.Add(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _dbConn.Faculties.Update(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Faculties faculties = _dbConn.Faculties.FirstOrDefault(row => row.Id == id) ?? new();
            faculties.IsActive = false;
            _dbConn.Faculties.Update(faculties);
            _dbConn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
