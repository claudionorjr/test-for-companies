using System;
using System.Collections.Generic;
using System.Linq;
using TestForCompanies.Models;
using Microsoft.EntityFrameworkCore;
using TestForCompanies.Services.Exceptions;

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

        public Purveyor FindById(int id)
        {
            return _context.Purveyor.Include(obj => obj.Company).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Purveyor.Find(id);
            _context.Purveyor.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Purveyor obj)
        {
            if (!_context.Purveyor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
