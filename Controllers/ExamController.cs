using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {

        public IActionResult Index()
        {
            List<Author> Authors = new List<Author>
                {
                    new Author {Id = 1, Ime = "Štef", Prezime = "Prekoplot"},
                    new Author {Id = 2, Ime = "Đoni", Prezime = "Vodokotlić"},
                    new Author {Id = 3, Ime = "Neven", Prezime = "Ničemiprišt"},
                };

            List<Book> Books = new List<Book>
            {
                new Book {id = 1, Naslov = "Vinčeka Crvena", Zanr = "Ljubić", Pisac = Authors[0]},
                new Book {id = 2, Naslov = "Vinčeka Belega", Zanr = "Horror", Pisac = Authors[0]},
                new Book {id = 3, Naslov = "Šekret u magli", Zanr = "SF", Pisac = Authors[1]},
                new Book {id = 4, Naslov = "Tajna malog potoka", Zanr = "Drama", Pisac = Authors[1]},
                new Book {id = 5, Naslov = "Kvazimodo", Zanr = "Medicina", Pisac = Authors[2]}
            };

            return View(Books);
        }
     }

    
}
