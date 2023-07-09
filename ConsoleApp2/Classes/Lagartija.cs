using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    public class Lagartija : Animales
    {
        // Propiedades
        private String nombreReptil;

        // Constructores
        public Lagartija(String nombre)
        {
            this.nombreReptil = nombre;
        }

        // Métodos
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {this.nombreReptil}.");
        }
    }
}
