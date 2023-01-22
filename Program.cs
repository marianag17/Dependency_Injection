using System;

namespace Dependency_Injection
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Laboratorio 1");
            //creación de objeto Wheel
            Wheel wheel = new Wheel(new Mechanic());

            //prueba de variable con scoped
            wheel.putWheel(false);
            wheel.check(false);
            wheel.putWheel(true);
            wheel.check(true);

            //pruebas de variable con transient, cambia????
            wheel = new Wheel(new Car());
            wheel.putWheel(true);
            wheel.check(false);
            wheel = new Wheel(new Car());
            wheel.putWheel(false);
            wheel.check(true);

            //prueba de variable con singleton
            wheel = new Wheel(new Motor());
            wheel.putWheel(true);
            wheel.check(true);
            Console.ReadKey();
        }
	}
}
