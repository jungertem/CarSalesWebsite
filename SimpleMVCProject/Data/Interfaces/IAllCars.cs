using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMVCProject.Data.Models;

namespace SimpleMVCProject.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> GetAllCars { get; set; }
        IEnumerable<Car> GetFavoriteCars { get; set; }
        Car GetObjectCar(int carId);
    }

}
