using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForCompanies.Models;

namespace TestForCompanies.Services
{
    public class FilterService
    {
        private readonly TestForCompaniesContext _context;

        public FilterService(TestForCompaniesContext context)
        {
            _context = context;
        }

        public async Task<List<Purveyor>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Purveyor select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.CreatedAt >= minDate.Value);
            }
            if ((maxDate).HasValue)
            {
                result = result.Where(x => x.CreatedAt <= maxDate.Value);
            }
            return await result
                .Include(x => x.Company)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }
    }
}
