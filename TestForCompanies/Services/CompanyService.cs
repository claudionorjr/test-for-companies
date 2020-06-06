using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForCompanies.Models;
using Microsoft.EntityFrameworkCore;

namespace TestForCompanies.Services
{
    public class CompanyService
    {
        private readonly TestForCompaniesContext _context;

        public CompanyService(TestForCompaniesContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> FindAllAsync()
        {
            return await _context.Company.OrderBy(x => x.TradingName).ToListAsync();
        }

    }
}
