using System;
using System.Collections.Generic;
using System.Linq;
using TestForCompanies.Models;
using Microsoft.EntityFrameworkCore;
using TestForCompanies.Services.Exceptions;
using System.Threading.Tasks;

namespace TestForCompanies.Services
{
    public class PurveyorService
    {
        private readonly TestForCompaniesContext _context;

        public PurveyorService(TestForCompaniesContext context)
        {
            _context = context;
        }

        public async Task<List<Purveyor>> FindAllAsync()
        {
            return await _context.Purveyor.ToListAsync();
        }

        public async Task InsertAsync(Purveyor obj)
        {
            obj.CreatedAt = DateTime.Now;
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Purveyor> FindByIdAsync(int id)
        {
            return await _context.Purveyor.Include(obj => obj.Company).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Purveyor.FindAsync(id);
            _context.Purveyor.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Purveyor obj)
        {
            bool hasAny = await _context.Purveyor.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
