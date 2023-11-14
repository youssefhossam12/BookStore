using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        
       private Repository<Book> data { get; set; }
        public HomeController(BookStoreContext ctx) => data = new Repository<Book>(ctx);
        public ViewResult Index() {
            // véletlen könyv választás
            var random = data.Get(new QueryOptions<Book>
            {
                OrderBy = b => Guid.NewGuid()
            });
            return View(random);
        }
        public ContentResult Register() {
            return Content("Registration has not been implemented yet.");
        }
        
    }
}