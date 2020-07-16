using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VehicleInsuranceCalculator.MVC.ViewModels
{
    public class InsuranceViewModel
    {
        [Key]
        public int InsuranceId { get; set; }

        [Required(ErrorMessage = "Fill in the Risk Rate field")]
        [DataType(DataType.Currency)]
        [DisplayName("Risk Rate")]
        public double RiskRate { get; set; }

        [Required(ErrorMessage = "Fill in the Risk Premium field")]
        [DataType(DataType.Currency)]
        [DisplayName("Risk Premium")]
        public double RiskPremium { get; set; }

        [Required(ErrorMessage = "Fill in the Pure Premium field")]
        [DataType(DataType.Currency)]
        [DisplayName("Pure Premium")]
        public double PurePremium { get; set; }

        [Required(ErrorMessage = "Fill in the Commercial Premium field")]
        [DataType(DataType.Currency)]
        [DisplayName("Commercial Premium")]
        public double CommercialPremium { get; set; }


        public int AssuredId { get; set; }
        public virtual AssuredViewModel Assured { get; set; }

        public int VehicleId { get; set; }
        public virtual VehicleViewModel Vehicle { get; set; }
    }
}