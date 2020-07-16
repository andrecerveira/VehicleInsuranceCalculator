using AutoMapper;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.MVC.ViewModels;

namespace VehicleInsuranceCalculator.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            Mapper.CreateMap<Assured, AssuredViewModel>();
            Mapper.CreateMap<Vehicle, VehicleViewModel>();
            Mapper.CreateMap<Insurance, InsuranceViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMapping"; }
        }
    }
}