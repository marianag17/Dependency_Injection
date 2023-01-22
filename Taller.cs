using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{

    internal class Motor : Car
    {

        public bool hasWheel;
        public bool check;

        // objeto Singleton
        //

        public ServiceLifetime single => ServiceLifetime.Singleton;


        public void putWheel(bool Wheel)
        {
            this.hasWheel = Wheel;
        }

        public void checkWheel(bool check)
        {
            this.check = check;
        }
    }


    internal class Car : ICar
    {
        public bool hasWheel;
        public bool check;
        //objeto Transient
        //

        public ServiceLifetime trans => ServiceLifetime.Transient;

		public ServiceLifetime serv => throw new NotImplementedException();

		public void putWheel(bool Wheel)
        {
            this.hasWheel = Wheel;
        }

        public void checkWheel(bool check)
        {
            this.check = check;
        }
    }


    internal class Mechanic : Car
    {
        public bool hasWheel;
        public bool check;
        //objeto Scoped
        //
        public ServiceLifetime scoped => ServiceLifetime.Scoped;
        

        public void putWheel(bool Wheel)
        {
            this.hasWheel = Wheel;
        }

        public void checkWheel(bool check)
        {
            this.check = check;
        }
    }

}
