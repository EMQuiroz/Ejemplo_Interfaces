using Entidades;

namespace Test_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paloma palomaUno = new("Lola", 2, "Aprobaste");
            Paloma palomaDos = new("Pepa", 2, "Aprobaste");
            Cartero carteroUno = new("Victor", 1, "Tengo una carta de tu Familia");
            Cartero carteroDos = new("Jose", 1, "Tengo la nota del examen de programacion");


            List<IMensaje> mensajeros = new List<IMensaje>();

            //Agrego los los objetos de distintos tipos que implementan la interfaz IMensaje
            mensajeros.Add(palomaUno);
            mensajeros.Add(palomaDos);
            mensajeros.Add(carteroUno);
            mensajeros.Add(carteroDos);

            foreach(IMensaje mensajero in mensajeros) 
            {
                Console.WriteLine(mensajero.EnviarMensaje());
            }


            Console.WriteLine("Fin del programa");
        }
    }
}