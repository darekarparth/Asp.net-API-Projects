using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace StateInfo.API.Profiles
{
    public class CityProfile : Profile//CityProfile inhererits the properties from Profile class. 
    {

        public CityProfile()
        {

            CreateMap<Entity.City, Models.CityWithoutPointsOfInterestDto>();//we create a map from City Entity to CityWithoutPointsOfInterestDto.//Here Source type is "Entities.City"  and Destination type is "Models.CityWithoutPointsOfInterestDto"

            CreateMap<Entity.City, Models.CityDto>();//we create a map from City Entity to CityDto
        }

    }
}
//Automapper is convention based. it will map property names on the Source Object to the same property names on the destination object.