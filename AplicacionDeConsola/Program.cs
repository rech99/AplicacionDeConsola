using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Jose", "Matricula", "Direccion", "Telefono");

           alumno1.Nombre;
            alumno1.Matricula;
            alumno1.Direccion;
            alumno1.Telefono;
            

            Console.WriteLine("Nombre: " );
            Console.WriteLine("Matricula: ");
            Console.WriteLine("Fecha de Nacimiento: ");
            Console.WriteLine("Direccion: ");
            Console.WriteLine("Telefono: " );
        }
    }
}
