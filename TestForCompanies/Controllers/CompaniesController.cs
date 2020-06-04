using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestForCompanies.Models;

namespace TestForCompanies.Controllers
{
    public class CompaniesController : Controller
    {
        //private readonly TestForCompaniesContext _context;

        //public CompaniesController(TestForCompaniesContext context)
        //{
        //   _context = context
        //}

        public IActionResult Index()
        {
            List<Company> list = new List<Company>();
            list.Add(new Company
            {
                Id = 1,
                Uf = "SC",
                TradingName = "Maxxi Gestão",
                Cnpj = "55.658.985/0001-55"
            });
            list.Add(new Company
            {
                Id = 2,
                Uf = "SP",
                TradingName = "Maxxi teste",
                Cnpj = "55.658.985/0001-55"
            });

            return View(list);
        }
    }
}