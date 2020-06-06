using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TestForCompanies.Models
{
    public class Purveyor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} Required! Don't Have CNPJ? put you name!")]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Owner Company")]
        public string CompanyName { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "State/UF")]
        public string Uf { get; set; }

        [Required]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Required]
        [Display(Name = "CPF")]
        [DataType(DataType.PhoneNumber)]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
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
