namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected int id;

        public Persona(): this ("si nombre",0)
        {

        }

        public Persona(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

    }


}