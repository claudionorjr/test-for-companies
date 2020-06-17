using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestForCompanies.Services;

namespace TestForCompanies.Controllers
{
    public class FiltersController : Controller
    {
        private readonly FilterService _filterService;

        public FiltersController(FilterService filterService)
        {
            _filterService = filterService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            maxDate = new DateTime(maxDate.Value.Year, maxDate.Value.Month, maxDate.Value.Day);
            var result = await _filterService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
    }
}