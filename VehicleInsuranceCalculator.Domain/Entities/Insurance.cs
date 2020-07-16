namespace VehicleInsuranceCalculator.Domain.Entities
{
    public class Insurance
    {
        public int InsuranceId { get; set; }

        public static double safetyMargin = 0.03;
        public static double profit = 0.05;

        public double RiskRate { get; set; }
        public double RiskPremium { get; set; }
        public double PurePremium { get; set; }
        public double CommercialPremium { get; set; }

        public int AssuredId { get; set; }
        public virtual Assured Assured { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }


    }
}
