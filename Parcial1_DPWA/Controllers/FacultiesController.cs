﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create()
        {
            Faculties faculties = new();
            return View(faculties);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Faculties model)
        {
            if (ModelState.IsValid)
            {
                _dbConn.Faculties.Add(model);
                _dbConn.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
