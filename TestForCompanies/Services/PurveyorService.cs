using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForCompanies.Models;

namespace TestForCompanies.Services
{
    public class PurveyorService
    {
        private readonly TestForCompaniesContext _context;

        public PurveyorService(TestForCompaniesContext context)
        {
            _context = context;
        }

        public List<Purveyor> FindAll()
        {
            return _context.Purveyor.ToList();
        }

        public void Insert(Purveyor obj)
        {
            obj.CreatedAt = DateTime.Now;
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
