using System;

namespace Persona
{
    public class Constructor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string Ocupacion { get; set; }
        public string LugarTrabajo { get; set; }
        public string Horario { get; set; }
        public string Resultado { get; set; }

        public void CrearPersona()
        {
            Resultado = (Nombre + " " + Apellido + " " + Cedula + " " +Ocupacion+ " " +LugarTrabajo+ " " +Horario);
        }
    }
}
