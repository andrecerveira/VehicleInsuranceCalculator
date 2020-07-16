using System.ComponentModel.DataAnnotations;

namespace VehicleInsuranceCalculator.MVC.ViewModels
{
    public class VehicleViewModel
    {
        [Key]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Fill in the value field")]
        [DataType(DataType.Currency)]
        public double Value { get; set; }

        [Required(ErrorMessage = "Fill in the brand field")]
        [MaxLength(50, ErrorMessage = "Maximum {0} characters")]
        [MinLength(2, ErrorMessage = "Minimum {0} characters")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Fill in the model field")]
        [MaxLength(50, ErrorMessage = "Maximum {0} characters")]
        [MinLength(2, ErrorMessage = "Minimum {0} characters")]
        public string Model { get; set; }

        [ScaffoldColumn(false)] //Faz com que este campo não seja criado quando fizer Scaffold
        public string BrandAndModel { get { return Brand + " - " + Model; } }

    }
}