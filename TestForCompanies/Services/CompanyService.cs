using System.Collections.Generic;
using System.Linq;
using TestForCompanies.Models;

namespace TestForCompanies.Services
{
    public class CompanyService
    {
        private readonly TestForCompaniesContext _context;

        public CompanyService(TestForCompaniesContext context)
        {
            _context = context;
        }

        public List<Company> FindAll()
        {
            return _context.Company.OrderBy(x => x.TradingName).ToList();
        }

    }
}
