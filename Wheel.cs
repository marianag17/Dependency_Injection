using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


//clase LLanta de carro
namespace Dependency_Injection
{
    public class Wheel
    {
        //atributo privado
        private readonly ICar Car;

        //constructor
        public Wheel(ICar Car)
        {
            this.Car = Car;
        }
        //métodos de la clase wheel
        public void putWheel(bool noWheel)
        {
            Car.putWheel(noWheel);
        }

        public void check(bool hasWheel)
        {
            Car.checkWheel(hasWheel);
        }
    }
}
