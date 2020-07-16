using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.MVC.Tests.Controllers
{
    [TestClass]
    public class InsuranceControllerTest
    {
        private readonly IInsuranceAppService _insuranceApp;
        public InsuranceControllerTest(IInsuranceAppService insuranceApp)
        {
            _insuranceApp = insuranceApp;
        }

        [TestMethod]
        public void VehicleInsuranceCalculation()
        {
            double vehicleValue = 10000;
            double expectedRiskRate = 2.5;
            double expectedRiskPremium = 250;
            double expectedPurePremium = 257.50;
            double expectedCommercialPremium = 270.38;

            Insurance testedInsurance = _insuranceApp.CalculateInsurance(vehicleValue);

            double actualRiskRate = testedInsurance.RiskRate;
            double actualRiskPremium = testedInsurance.RiskPremium;
            double actualPurePremium = testedInsurance.PurePremium;
            double actualCommercialPremium = testedInsurance.CommercialPremium;

            Assert.AreEqual(expectedRiskRate, actualRiskRate, 0, "Incorrect riskRate");
            Assert.AreEqual(expectedRiskPremium, actualRiskPremium, 0, "Incorrect actualRiskPremium");
            Assert.AreEqual(expectedPurePremium, actualPurePremium, 0, "Incorrect actualPurePremium");
            Assert.AreEqual(expectedCommercialPremium, actualCommercialPremium, 0, "Incorrect actualCommercialPremium");
        }
    }
}
