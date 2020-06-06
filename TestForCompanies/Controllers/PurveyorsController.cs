﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TestForCompanies.Models;
using TestForCompanies.Models.ViewModels;
using TestForCompanies.Services;
using TestForCompanies.Services.Exceptions;

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

        public IActionResult Index()
        {
            var list = _purveyorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var companies = _companyService.FindAll();
            var viewModel = new PurveyorFormViewModel { Companies = companies };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Purveyor purveyor)
        {
            DateTime timeNow = DateTime.Now;
            DateTime ageNow = purveyor.BirthDate;

            if (timeNow.Year - ageNow.Year < 19 && purveyor.Uf == "PR" && ageNow.Month <= timeNow.Month && ageNow.Day < timeNow.Day)
            {
                return RedirectToAction(nameof(Error), new { message = "You can't have age >= 18, in State 'PR'" });
            }
            
            _purveyorService.Insert(purveyor);
            return RedirectToAction(nameof(Index));
            
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _purveyorService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _purveyorService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _purveyorService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _purveyorService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Company> companies = _companyService.FindAll();
            PurveyorFormViewModel viewModal = new PurveyorFormViewModel { Purveyor = obj, Companies = companies };
            return View(viewModal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Purveyor purveyor)
        {
            if (id != purveyor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                _purveyorService.Update(purveyor);
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