using AutoMapper;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.Query;

public class WeatherProfile : Profile
{
    public WeatherProfile()
    {
        CreateMap<Weather, WeatherDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForAllMembers(x => x.ExplicitExpansion());
    }
}