using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CarController : ControllerBase
    {
        public List<Car> cars = new List<Car>
        {
            new Car("Ford", "Bronco", 1985, "red"),
            new Car("Ford", "Escort", 1986, "blue"),
            new Car("Chevrolet", "Caprice", 1983, "purple"),
            new Car("Honda", "Accord", 1990, "grey"),
            new Car("Cadillac", "El Dorado", 1985, "black"),
            new Car("Lincoln", "Continental", 1985, "green"),
            new Car("Ford", "Escape", 1995, "pink"),
            new Car("Ford", "Bronco", 2003, "yellow"),
            new Car("Ford", "Bronco", 2004, "silver"),
            new Car("Ford", "Bronco", 2000, "gold"),
        };

       [HttpGet]

       public List<Car> GetAllCars()
        {
            return cars; 
        }

       [HttpGet("GetCar/{index}")]
       public Car GetCarByIndex(int index)
        {
            Car errorCar = new Car("Error", "Error", 0000, "Invalid car Index");
            try
            {

            return cars[index]; 

            }
            catch
            {
                return errorCar;
            }
        }

        [HttpGet("GetCarByMake/{make}")]
        public List<Car> GetCarByMake(string make)
        {
            List<Car> newCarListByMake = new List<Car>(); 
            foreach(Car c in cars)
            {
                if(make.ToLower() == c.Make.ToLower())
                {
                    newCarListByMake.Add(c);
                }
            }

            return newCarListByMake; 
        }

        [HttpGet("GetCarByColor/{color}")]
        public List<Car> GetCarByColor(string color)
        {
            List<Car> newCarListByColor = new List<Car>();
            foreach (Car c in cars)
            {
                if (color.ToLower() == c.Color.ToLower())
                {
                    newCarListByColor.Add(c);
                }
            }

            return newCarListByColor;
        }


    }
}
