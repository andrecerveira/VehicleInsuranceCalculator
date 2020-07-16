using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VehicleInsuranceCalculator.MVC.ViewModels
{
    public class AssuredViewModel
    {
        [Key]
        public int AssuredId { get; set; }

        [Required(ErrorMessage = "Fill in the name field")]
        [MaxLength(50, ErrorMessage = "Maximum {0} characters")]
        [MinLength(2, ErrorMessage = "Minimum {0} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CPF Required")]
        [CustomValidationCPF(ErrorMessage = "Invalid CPF")]
        [DisplayName("CPF")]
        public string cpf { get; set; }
        
        public virtual IEnumerable<InsuranceViewModel> InsurancePlans { get; set; }
    }
}