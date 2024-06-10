using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        protected string nombre;
        protected int edad;

        protected Animal():this("Animal sin nombre",0)
        {

        }

        protected Animal(string nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }

    }
}
