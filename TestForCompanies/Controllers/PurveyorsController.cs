using Microsoft.AspNetCore.Mvc;
using TestForCompanies.Models;
using TestForCompanies.Services;

namespace TestForCompanies.Controllers
{
    public class PurveyorsController : Controller
    {
        private readonly PurveyorService _purveyorsService;

        public PurveyorsController(PurveyorService purveyorsService)
        {
            _purveyorsService = purveyorsService;
        }

        public IActionResult Index()
        {
            var list = _purveyorsService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Purveyor purveyor)
        {
            _purveyorsService.Insert(purveyor);
            return RedirectToAction(nameof(Index));
        }
    }
}