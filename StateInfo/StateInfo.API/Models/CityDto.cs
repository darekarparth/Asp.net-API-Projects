using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterest //returns the number/count of point of interest. 
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
         = new List<PointOfInterestDto>();// CityDto contains the collection of Point of interest
    }
}
