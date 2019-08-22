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
            Alumno alumno1 = new Alumno();



            Console.WriteLine("Alumno 1");
            Console.WriteLine("Nombre: " + alumno1.Nombre );
            Console.WriteLine("Matricula: " + alumno1.Matricula);
            Console.WriteLine("Fecha de Nacimiento: ");
            Console.WriteLine("Direccion: ");
            Console.WriteLine("Telefono: " );


            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Pedro";
            alumno2.Matricula = ("29053");


            Console.WriteLine("Alumno 2");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            Alumno alumno3 = new Alumno("Ana", "26789");
            Console.WriteLine("Alumno 3");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);


            Console.Read();
        }
        
    }
}
