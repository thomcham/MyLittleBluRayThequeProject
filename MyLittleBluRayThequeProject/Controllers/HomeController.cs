using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyLittleBluRayThequeProject.Models;
using MyLittleBluRayThequeProject.Repositories;
using System.Diagnostics;

namespace MyLittleBluRayThequeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;

        private readonly IBluRayRepository brRepository;

        public HomeController(ILogger<HomeController> logger, IBluRayRepository brRepository, IMapper mapper)
        {
            _logger = logger;
            this.mapper = mapper;
            this.brRepository = brRepository;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.BluRays = brRepository.GetListeBluRay();
            return View(model);
        }

        public IActionResult SelectedBluRay(long? id)
        {
            IndexViewModel model = new IndexViewModel();
            model.BluRays = brRepository.GetListeBluRay();
            if(id != null)
            {
                model.SelectedBluRay = model.BluRays.FirstOrDefault(x => x.Id == id);
            }
            return View(model);
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
        public void OnPost()
        {
            var nom = Request.Form["Nom"];
            Console.WriteLine("Réussi ! "+ nom);
        }
    }
}