using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola
{
    class Alumno
    {
        public string Nombre { get; set; }

        public string Matricula { get; set; }

        public DateTime Fecha { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public Alumno(string nombre, string matricula, string direccion, string telefono)
        {

            Direccion = direccion;
            Telefono = telefono;
        }
        public Alumno(string nombre, string matricula)
        {
            Nombre = "Sin Asignar";
            Matricula = "Sin Asignar";
        }


}
}
