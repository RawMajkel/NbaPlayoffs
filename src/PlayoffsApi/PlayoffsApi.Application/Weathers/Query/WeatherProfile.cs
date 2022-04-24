using AutoMapper;
using HashidsNet;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.Query;

public class WeatherProfile : Profile
{
    public WeatherProfile(IHashids hashIds)
    {
        CreateMap<Weather, WeatherDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => hashIds.Encode(src.Id.Value)))
            .ForAllMembers(x => x.ExplicitExpansion());
    }
}