using System;
using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Services;

namespace VehicleInsuranceCalculator.Application
{
    public class InsuranceAppService : AppServiceBase<Insurance>, IInsuranceAppService
    {
        private readonly IInsuranceService _insuranceService;

        public InsuranceAppService(IInsuranceService insuranceService)
            : base(insuranceService)
        {
            _insuranceService = insuranceService;
        }

        public Insurance CalculateInsurance(double vehicleValue)
        {
            double riskRateCalculated = (vehicleValue * 5) / (vehicleValue * 2);
            double riskPremiumCalculated = vehicleValue * (riskRateCalculated /100);
            double purePremiumCalculated = riskPremiumCalculated * (1 + Insurance.safetyMargin);
            double commercialPremiumCalculated = purePremiumCalculated + (purePremiumCalculated * Insurance.profit);

            return new Insurance()
            {
                RiskRate = riskRateCalculated,
                RiskPremium = riskPremiumCalculated,
                PurePremium = purePremiumCalculated,
                CommercialPremium = Math.Round(commercialPremiumCalculated, 2)

            };
        }


        //public IEnumerable<Insurance> SearchForName(string name)
        //{
        //    return _insuranceService.SearchForName(name);
        //}
    }
}
