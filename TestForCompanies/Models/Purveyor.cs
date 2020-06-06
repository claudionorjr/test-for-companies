using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TestForCompanies.Models
{
    public class Purveyor
    {
        public int Id { get; set; }

        [Display(Name = "Owner Company")]
        public string CompanyName { get; set; }

        public string Name { get; set; }

        [Display(Name = "State/UF")]
        public string Uf { get; set; }

        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "CPF")]
        [DataType(DataType.PhoneNumber)]
        public string Cpf { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public Company Company { get; set; }

        [Display(Name = "Work To Company")]
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
