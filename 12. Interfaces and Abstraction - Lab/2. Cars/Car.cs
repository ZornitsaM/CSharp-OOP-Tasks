using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar
    {
        protected Car(string model, string color)
        {

            this.Model = model;
            this.Color = color;
         
        }
        public string Model { get; }

        public string Color { get; }

        public string Start()
        {
            return "";
        }

        public string Stop()
        {
            return "";
        }
    }
}
