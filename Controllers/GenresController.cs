﻿using Meu_Bookstore.Data;
using Meu_Bookstore.Models;
using Meu_Bookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Meu_Bookstore.Controllers
{
    public class GenresController : Controller
    {
		private readonly GenreService _service;

		public GenresController(GenreService service)
		{
			_service = service;
		}

		public IActionResult Index()
        {

            return View(_service.FindAll());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.Insert(genre);

            return RedirectToAction(nameof(Index));
        }
    }
}
