using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StateInfo.API.Models;
using StateInfo.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetCities()
        //{
        //    return Ok(CityDataStore.Current.Cities);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetSingleCity(int Id)
        //{
        //    var cityToReturn = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == Id);
        //    if (cityToReturn == null)
        //    {
        //        return NotFound(); //returns us 404 not found request 
        //    }
        //    return Ok(cityToReturn);
        //}
        //-------------------------------------------------------------------------------------------------------

        private readonly ICityInfoRepository _cityInfoRepository;
        private readonly IMapper _mapper;


        public CitiesController(ICityInfoRepository cityInfoRepository, IMapper mapper)// constructor. we inject IMapper 
        {
            _cityInfoRepository = cityInfoRepository ??
              throw new ArgumentNullException(nameof(cityInfoRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));//initializes a new instance of ArgumentNullException class with name of parameter that causes this exception.
        }



        [HttpGet]
        public IActionResult GetCities()
        {
            var cityEntities = _cityInfoRepository.GetCities();

            //var results = new List<CityWithoutPointsOfInterestDto>();

            //foreach (var cityEntity in cityEntities)
            //{
            //    results.Add(new CityWithoutPointsOfInterestDto
            //    {
            //        Id = cityEntity.Id,
            //        Description = cityEntity.Description,
            //        Name = cityEntity.Name
            //    });
            //}

            return Ok(_mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities)); //mapper statement//execute mapping from source object to destination object.
            //return Ok(results);                                                               //we pass through enitities we want to map this cityEntities.    
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                 return Ok(_mapper.Map<CityDto>(city));// if includePointsOfInterest then we map to CityDto

                //var cityResult = new CityDto()
                //{
                //    Id = city.Id,
                //    Name = city.Name,
                //    Description = city.Description
                //};
            //foreach(var poi in city.PointsOfInterest)
            //    {
            //        cityResult.PointsOfInterest.Add(
            //            new PointOfInterestDto()
            //            {
            //                Id = poi.Id,
            //                Name= poi.Name,
                            
            //            });
            //    }
                
            }

            //var citywithoutPointOfInterestResult = new CityWithoutPointsOfInterestDto()
            //{
            //    Id = city.Id,
            //    Name = city.Name,
            //    Description = city.Description
            //};
            //return Ok(citywithoutPointOfInterestResult);
            return Ok(_mapper.Map<CityWithoutPointsOfInterestDto>(city));
        }
    }
}
