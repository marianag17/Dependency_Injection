using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    //interfaz de carro
    public interface ICar
    {

        //atributos por defecto


        void checkWheel(bool check);
        void putWheel(bool hasWheel);
        ServiceLifetime serv { get; }
    }
}
