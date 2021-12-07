using StateInfo.API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Services
{
    public interface ICityInfoRepository
    {
        
        IEnumerable<City> GetCities();

        City GetCity(int cityId,bool includePointOfInterest);

        IEnumerable<PointOfInterest> GetPointsOfInterestsForCity(int cityId);
        PointOfInterest GetPointOfInterestsForCity(int cityId , int pointOfInterestId);

        bool CityExists(int cityId);

        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

        void UpdatePointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

        void DeletePointOfInterest(PointOfInterest pointOfInterest);
        bool Save();
    }
}
