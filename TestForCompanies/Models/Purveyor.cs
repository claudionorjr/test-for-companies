using System;
using System.Linq;

namespace TestForCompanies.Models
{
    public class Purveyor
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Uf { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public Purveyor()
        {
        }

        public Purveyor(int id, string companyName, string name, string uf, string rg, string cpf, string cnpj, DateTime createdAt, DateTime birthDate, string phone, Company company)
        {
            Id = id;
            CompanyName = companyName;
            Name = name;
            Uf = uf;
            Rg = rg;
            Cpf = cpf;
            Cnpj = cnpj;
            CreatedAt = DateTime.Now;
            BirthDate = birthDate;
            Phone = phone;
            Company = company;
        }
    }
}
