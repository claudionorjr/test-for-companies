using System;
using System.Linq;
using TestForCompanies.Models;

namespace TestForCompanies.Data
{
    public class SeedingService
    {
        private TestForCompaniesContext _context;

        public SeedingService(TestForCompaniesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Company.Any() || _context.Purveyor.Any())
            {
                return;
            }

            Company c1 = new Company(1, "SC", "Mercado Ms", "55.698.517/5555.66");
            Company c2 = new Company(2, "SC", "Rio Madeiras", "55.698.517/5555.66");
            Company c3 = new Company(3, "SC", "Serviços Ferragens", "55.698.517/5555.66");
            Company c4 = new Company(4, "SC", "Farma Centro", "55.698.517/5555.66");

            Purveyor p1 = new Purveyor(1, "", "Bob", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 1, 10), new DateTime(1998, 5, 6), "(47) 999999999", c1);
            Purveyor p2 = new Purveyor(2, "", "Joao", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 2, 10), new DateTime(1997, 5, 6), "(47) 999999999", c2);
            Purveyor p3 = new Purveyor(3, "", "Pedro", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 3, 10), new DateTime(1996, 5, 6), "(47) 999999999", c3);
            Purveyor p4 = new Purveyor(4, "", "Marcos", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 4, 10), new DateTime(1995, 5, 6), "(47) 999999999", c4);
            Purveyor p5 = new Purveyor(5, "", "Silva", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 5, 10), new DateTime(1994, 5, 6), "(47) 999999999", c1);
            Purveyor p6 = new Purveyor(6, "", "Romario", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 1, 10), new DateTime(1993, 5, 6), "(47) 999999999", c2);
            Purveyor p7 = new Purveyor(7, "", "Jonatan", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 2, 10), new DateTime(1980, 5, 6), "(47) 999999999", c3);
            Purveyor p8 = new Purveyor(8, "", "Jones", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 3, 10), new DateTime(1981, 5, 6), "(47) 999999999", c4);
            Purveyor p9 = new Purveyor(9, "", "Marcio", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 4, 10), new DateTime(1983, 5, 6), "(47) 999999999", c1);
            Purveyor p10 = new Purveyor(10, "", "Maria", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 5, 10), new DateTime(1983, 5, 6), "(47) 999999999", c2);
            Purveyor p11 = new Purveyor(11, "", "Joana", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 1, 10), new DateTime(1984, 5, 6), "(47) 999999999", c3);
            Purveyor p12 = new Purveyor(12, "", "Ana", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 2, 10), new DateTime(1998, 5, 6), "(47) 999999999", c3);
            Purveyor p13 = new Purveyor(13, "", "Adriana", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 3, 10), new DateTime(1998, 5, 6), "(47) 999999999", c4);
            Purveyor p14 = new Purveyor(14, "", "Adriana", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 4, 10), new DateTime(2000, 5, 6), "(47) 999999999", c4);
            Purveyor p15 = new Purveyor(15, "", "Adriana", "SC", "5.987.654", "000.000.123-45", "", new DateTime(2020, 5, 10), new DateTime(1996, 5, 6), "(47) 999999999", c4);

            _context.Company.AddRange(c1, c2, c3, c4);
            _context.Purveyor.AddRange(
                p1, p2, p3, p4, p5,
                p6, p7, p8, p9, p10,
                p11, p12, p13, p14, p15
            );

            _context.SaveChanges();
        }
    }
}
