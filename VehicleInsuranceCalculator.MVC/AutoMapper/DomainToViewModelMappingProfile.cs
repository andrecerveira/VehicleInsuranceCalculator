using AutoMapper;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.MVC.ViewModels;

namespace VehicleInsuranceCalculator.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            Mapper.CreateMap<AssuredViewModel, Assured>();
            Mapper.CreateMap<VehicleViewModel, Vehicle>();
            Mapper.CreateMap<InsuranceViewModel, Insurance>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMapping"; }
        }
    }
}