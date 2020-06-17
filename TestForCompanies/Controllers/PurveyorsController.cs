using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using TestForCompanies.Models;
using TestForCompanies.Models.ViewModels;
using TestForCompanies.Services;

namespace TestForCompanies.Controllers
{
    public class PurveyorsController : Controller
    {
        private readonly PurveyorService _purveyorService;
        private readonly CompanyService _companyService;

        public PurveyorsController(PurveyorService purveyorService, CompanyService companyService)
        {
            _purveyorService = purveyorService;
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _purveyorService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var companies = await _companyService.FindAllAsync();
            var viewModel = new PurveyorFormViewModel { Companies = companies };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Purveyor purveyor)
        {
            if (!ModelState.IsValid)
            {
                var companies = await _companyService.FindAllAsync();
                var viewModel = new PurveyorFormViewModel { Companies = companies };
                return View(viewModel);
            }

            DateTime timeNow = DateTime.Now;
            DateTime ageNow = purveyor.BirthDate;

            if (timeNow.Year - ageNow.Year < 19 && purveyor.Uf == "PR" && ageNow.Month <= timeNow.Month && ageNow.Day < timeNow.Day)
            {
                return RedirectToAction(nameof(Error), new { message = "You need have age '18' or more, in State 'PR'." });
            }

            if (!ModelState.IsValid)
            {
                return View(purveyor);
            }

            try
            {
                await _purveyorService.InsertAsync(purveyor);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _purveyorService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _purveyorService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _purveyorService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _purveyorService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Company> companies = await _companyService.FindAllAsync();
            PurveyorFormViewModel viewModal = new PurveyorFormViewModel { Purveyor = obj, Companies = companies };
            return View(viewModal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Purveyor purveyor)
        {
            DateTime timeNow = DateTime.Now;
            DateTime ageNow = purveyor.BirthDate;

            if (timeNow.Year - ageNow.Year < 19 && purveyor.Uf == "PR" && ageNow.Month <= timeNow.Month && ageNow.Day < timeNow.Day)
            {
                return RedirectToAction(nameof(Error), new { message = "You need have age 18 or more, in State PR." });
            }

            if (!ModelState.IsValid)
            {
                return View(purveyor);
            }

            if (!ModelState.IsValid)
            {
                var companies = await _companyService.FindAllAsync();
                var viewModel = new PurveyorFormViewModel { Companies = companies };
                return View(viewModel);
            }

            if (!ModelState.IsValid)
            {
                return View(purveyor);
            }

            if (id != purveyor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                await _purveyorService.UpdateAsync(purveyor);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}