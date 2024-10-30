using Meu_Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Meu_Bookstore.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Terror"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Horror Cósmico"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Comédia"
                }
            };

            return View(genres);
        }
    }
}
