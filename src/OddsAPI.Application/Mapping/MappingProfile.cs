using AutoMapper;
using OddsAPI.Core.Entities;
using OddsAPI.Core.Models;
using OddsAPI.Application.DTOs;

namespace OddsAPI.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Odds, OddsDto>().ReverseMap();
        CreateMap<CreateOddsDto, Odds>();
        CreateMap<UpdateOddsDto, Odds>();

        CreateMap<Market, MarketDto>();
        CreateMap<CreateMarketDto, Market>();
        CreateMap<UpdateMarketDto, Market>();

        CreateMap<Entity, EntityDto>();
        CreateMap<CreateEntityDto, Entity>();
        CreateMap<UpdateEntityDto, Entity>();
    }
} 