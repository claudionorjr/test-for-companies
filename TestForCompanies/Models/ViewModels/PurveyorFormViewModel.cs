using System.Collections.Generic;

namespace TestForCompanies.Models.ViewModels
{
    public class PurveyorFormViewModel
    {
        public Purveyor Purveyor { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
