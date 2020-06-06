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

            Purveyor p1 = new Purveyor(1, "Bob", "Bob", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 1, 5), new DateTime(1998, 5, 6), "(47) 999999999", c1);
            Purveyor p2 = new Purveyor(2, "Joao", "Joao", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 2, 10), new DateTime(1997, 5, 6), "(47) 999999999", c2);
            Purveyor p3 = new Purveyor(3, "Pedro", "Pedro", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 3, 25), new DateTime(1996, 5, 6), "(47) 999999999", c3);
            Purveyor p4 = new Purveyor(4, "Marcos", "Marcos", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 4, 13), new DateTime(1995, 5, 6), "(47) 999999999", c4);
            Purveyor p5 = new Purveyor(5, "Silva", "Silva", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 5, 14), new DateTime(1994, 5, 6), "(47) 999999999", c1);
            Purveyor p6 = new Purveyor(6, "Romario", "Romario", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 1, 15), new DateTime(1993, 5, 6), "(47) 999999999", c2);
            Purveyor p7 = new Purveyor(7, "Jonatan", "Jonatan", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 2, 16), new DateTime(1980, 5, 6), "(47) 999999999", c3);
            Purveyor p8 = new Purveyor(8, "Jones", "Jones", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 3, 17), new DateTime(1981, 5, 6), "(47) 999999999", c4);
            Purveyor p9 = new Purveyor(9, "Marcio", "Marcio", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 4, 10), new DateTime(1983, 5, 6), "(47) 999999999", c1);
            Purveyor p10 = new Purveyor(10, "Maria", "Maria", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 5, 10), new DateTime(1983, 5, 6), "(47) 999999999", c2);
            Purveyor p11 = new Purveyor(11, "Joana", "Joana", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 1, 10), new DateTime(1984, 5, 6), "(47) 999999999", c3);
            Purveyor p12 = new Purveyor(12, "Ana", "Ana", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 2, 10), new DateTime(1998, 5, 6), "(47) 999999999", c3);
            Purveyor p13 = new Purveyor(13, "Adriana", "Adriana", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 3, 5), new DateTime(1998, 5, 6), "(47) 999999999", c4);
            Purveyor p14 = new Purveyor(14, "Silva", "Silva", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 4, 2), new DateTime(2000, 5, 6), "(47) 999999999", c4);
            Purveyor p15 = new Purveyor(15, "Eliza", "Eliza", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 5, 3), new DateTime(1996, 5, 6), "(47) 999999999", c4);
            Purveyor p16 = new Purveyor(16, "Roberto", "Roberto", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 1, 7), new DateTime(1998, 5, 6), "(47) 999999999", c1);
            Purveyor p17 = new Purveyor(17, "Claudio", "Claudio", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 2, 8), new DateTime(1997, 5, 6), "(47) 999999999", c2);
            Purveyor p18 = new Purveyor(18, "Valdir", "Valdir", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 3, 8), new DateTime(1996, 5, 6), "(47) 999999999", c3);
            Purveyor p19 = new Purveyor(19, "Claudia", "Claudia", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 4, 8), new DateTime(1995, 5, 6), "(47) 999999999", c4);
            Purveyor p20 = new Purveyor(20, "Alessandra", "Alessandra", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 5, 8), new DateTime(1994, 5, 6), "(47) 999999999", c1);
            Purveyor p21 = new Purveyor(21, "Marcela", "Marcela", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 1, 8), new DateTime(1993, 5, 6), "(47) 999999999", c2);
            Purveyor p22 = new Purveyor(22, "Larissa", "Larissa", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 2, 8), new DateTime(1980, 5, 6), "(47) 999999999", c3);
            Purveyor p23 = new Purveyor(23, "Thiago", "Thiago", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 3, 9), new DateTime(1981, 5, 6), "(47) 999999999", c4);
            Purveyor p24 = new Purveyor(24, "Gulherme", "Gulherme", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 4, 9), new DateTime(1983, 5, 6), "(47) 999999999", c1);
            Purveyor p25 = new Purveyor(25, "Gustavo", "Gustavo", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 5, 9), new DateTime(1983, 5, 6), "(47) 999999999", c2);
            Purveyor p26 = new Purveyor(26, "Renata", "Renata", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 1, 10), new DateTime(1984, 5, 6), "(47) 999999999", c3);
            Purveyor p27 = new Purveyor(27, "Bruna", "Bruna", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 2, 10), new DateTime(1998, 5, 6), "(47) 999999999", c3);
            Purveyor p28 = new Purveyor(28, "Priscila", "Priscila", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 3, 11), new DateTime(1998, 5, 6), "(47) 999999999", c4);
            Purveyor p29 = new Purveyor(29, "Mathias", "Mathias", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 4, 11), new DateTime(2000, 5, 6), "(47) 999999999", c4);
            Purveyor p30 = new Purveyor(30, "Jorge", "Jorge", "SC", "5.987.654", "000.000.123-45", "55.555.555/0001-55", new DateTime(2020, 5, 11), new DateTime(1996, 5, 6), "(47) 999999999", c4);

            _context.Company.AddRange(c1, c2, c3, c4);
            _context.Purveyor.AddRange(
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15,
                p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30
            );

            _context.SaveChanges();
        }
    }
}
