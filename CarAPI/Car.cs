using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    public Car(string Make, string Model, int Year, string Color)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Color = Color;
    }

    }

}
