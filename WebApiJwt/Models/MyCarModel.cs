using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiJwt.Models
{
    public class MyCarModel
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        public double Width { get; set; }
        public double Height { get; set; }

        
        public class CarType
        {
            public string Color { get; set; }
            public string Seat { get; set; }
        }
        public class Car
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public List<CarType> Attribute { get; set; }

            public static implicit operator List<object>(Car v)
            {
                throw new NotImplementedException();
            }
        }

    }
    
}