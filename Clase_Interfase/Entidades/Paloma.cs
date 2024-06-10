using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paloma : Animal, IMensaje
    {
        private string mensaje;
        public Paloma(string nombre,int edad,string mensaje):base(nombre, edad) 
        {
            this.mensaje = mensaje;
        } 

        public string EnviarMensaje()
        {
            return $"Soy una paloma, me llamo: {base.nombre} y el mensaje es{this.mensaje}";
        }
    }
}
