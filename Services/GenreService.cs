using Meu_Bookstore.Controllers;
using Meu_Bookstore.Data;
using Meu_Bookstore.Models;

namespace Meu_Bookstore.Services
{
	public class GenreService
	{
		private readonly BookstoreContext _context;

		public GenreService(BookstoreContext context)
		{
			_context = context;
		}

		public List<Genre> FindAll()
		{
			return _context.Genres.ToList();
		}
	}
}
