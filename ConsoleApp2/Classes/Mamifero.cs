using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    public class Mamifero : Animales
    {
        // Propiedades
        private String nombreMamifero;

        // Constructores
        public Mamifero(String nombre)
        {
            this.nombreMamifero = nombre;
        }

        // Métodos
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por sí solas");
        }

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del mamífero es: {this.nombreMamifero}.");
        }
    }
}
