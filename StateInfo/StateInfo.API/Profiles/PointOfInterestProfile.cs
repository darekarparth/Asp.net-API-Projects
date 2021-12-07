using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entity.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForCreationDto, Entity.PointOfInterest>();
            CreateMap<Models.PointOfInterestForUpdationDto, Entity.PointOfInterest>();
            CreateMap<Entity.PointOfInterest, Models.PointOfInterestForUpdationDto>();

        }
    }
}
