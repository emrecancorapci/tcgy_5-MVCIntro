using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcIntro.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mvcIntro.Entities;
using mvcIntro.Business;

namespace mvcIntro.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ISurveyService _surveyService;
        private readonly IFeaturedService _featuredService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IBookService bookService, ISurveyService surveyService, IFeaturedService featuredService)
        {
            _bookService = bookService;
            _surveyService = surveyService;
            _featuredService = featuredService;
            _logger = logger;
        }

        public IActionResult Index(int page = 1)
        {
            var books = _bookService.GetBooks();
            const int productsPerPage = 3;

            var paginatedBooks = books
                .OrderBy(x => x.Id)
                .Skip((page - 1) * productsPerPage)
                .Take(productsPerPage);

            _bookService.AddCount();
            _featuredService.AddCount();
            _surveyService.AddCount();
            

            ViewBag.TotalPages = Math.Ceiling((double)books.Count / productsPerPage);
            ViewBag.Scoped = _bookService.GetCount();
            ViewBag.Singleton = _featuredService.GetCount();
            ViewBag.Transient = _surveyService.GetCount();

            return View(paginatedBooks);
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
