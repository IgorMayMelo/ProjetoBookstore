using Meu_Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Meu_Bookstore.Data
{
	public class BookstoreContext : DbContext
	{
		public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
		{
		}

		public DbSet<Genre> Genres { get; set; }

		public DbSet<Book> Books { get; set; }
	}
}
