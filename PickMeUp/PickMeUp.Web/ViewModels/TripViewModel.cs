namespace PickMeUp.Web.ViewModels
{
    using AutoMapper;
    using PickMeUp.Models;
    using PickMeUp.Web.Infrastructure.Mapping;

    public class TripViewModel : IMapFrom<Trip>, IHaveCustomMappings
    {
        public int AvailableSeats { get; set; }

        public decimal Price { get; set; }

        public int VotePoints { get; set; }

        public string AdditionalInfo { get; set; }

        public string Driver { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        // TODO: Comments and Passangers

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Trip, TripViewModel>()
               .ForMember(m => m.Driver, opt => opt.MapFrom(u => u.Driver.UserName));

            configuration.CreateMap<Trip, TripViewModel>()
               .ForMember(m => m.From, opt => opt.MapFrom(u => u.From.Name));

            configuration.CreateMap<Trip, TripViewModel>()
               .ForMember(m => m.To, opt => opt.MapFrom(u => u.To.Name));
        }
    }
}