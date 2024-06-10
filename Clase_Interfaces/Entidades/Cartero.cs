using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensajero : Persona, IMensaje
    {
        private string mensaje;
        public Mensajero(string nombre,int id,string mensaje):base(nombre,id)
        {
            this.mensaje = mensaje;
        }

        public string EnviarMensaje()
        {
            return $"Me llamo {base.nombre} y el mensaje es: {this.mensaje}";
        }
    }
}
