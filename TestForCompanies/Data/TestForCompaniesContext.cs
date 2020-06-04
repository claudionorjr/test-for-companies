using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TestForCompanies.Models
{
    public class TestForCompaniesContext : DbContext
    {
        public TestForCompaniesContext(DbContextOptions<TestForCompaniesContext> options) : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Purveyor> Purveyor { get; set; }
    }
}
