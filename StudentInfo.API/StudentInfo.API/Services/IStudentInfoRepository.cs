using StudentInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Services
{
    //Class describes the attributes and behaviour of an object.
    //interface is implemented using class. An Interface contains behaviour that a class implements.
    public interface IStudentInfoRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetSingleStudent(int id);
        bool StudentExists(int id);
        void AddStudent( Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        bool Save();

    }
}
//IEnumerable<City> GetCities();//GetCities() is method which has IEnumerable<City> as datatype.So when GetCities method is hit ,It return us IEnumerable of Cities.

//City GetCity(int cityId, bool includePointsOfInterest);// IEnumerable<City> GetCities(); method return us cities,  City GetCity(int cityId) method that accepts cityId fetch us specific city. Here  City is datatype, that contains cities. 

//IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);//same expalaination as above

//PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);//same expalaination as above//specific Point Of Interest for specific city.

//bool CityExists(int cityId);//

//void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

//void UpdatePointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

//void DeletePointOfInterest(PointOfInterest pointOfInterest);

//bool Save();