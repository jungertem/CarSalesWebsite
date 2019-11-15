using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMVCProject.Data.Interfaces;
using SimpleMVCProject.Data.Models;

namespace SimpleMVCProject.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
        public IEnumerable<Car> GetAllCars
        {
            get => new List<Car>
            {
                new Car
                {
                    Name = "Tesla",
                    ShortDescription="Fast ang worthy",
                    LongDescription="Cutting egde technologies are inside",
                    Image = "https://stimg.cardekho.com/images/carexteriorimages/630x420/Tesla/Tesla-Model-S/4615/1551164231212/front-left-side-47.jpg?tr=w-420,e-sharpen",
                    Price = 70000,
                    IsFavorite = true,
                    category = categoryCars.AllCategories.First()
                },
                new Car
                {
                    Name = "BMW X7",
                    ShortDescription="So beautiful and expencive car",
                    LongDescription="Emphasize your wealth and status. Classic car model for real men.",
                    Image = "https://cdn.autocentre.ua/wp-content/uploads/2018/10/2019-bmw-x7.jpg",
                    Price = 125000,
                    IsFavorite = true,
                    category = categoryCars.AllCategories.Last()
                },
                new Car
                {
                    Name = "Mercedes-Benz G-Class",
                    ShortDescription="Extremely fashionable",
                    LongDescription="It just feels like a fresh breath of air",
                    Image = "https://www.mbusa.com/content/dam/mb-nafta/us/myco/my19/g/byo/options/2019-G-CLASS-AMG-SUV-010.jpg",
                    Price = 45001,
                    IsFavorite = true,
                    category = categoryCars.AllCategories.Last()
                }
               

            };

            set => throw new NotImplementedException();
        }
        public IEnumerable<Car> GetFavoriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
