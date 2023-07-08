using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    public class Mamifero
    {
        // Propiedades
        private String nombreSerVivo;

        // Constructores
        public Mamifero(String nombre)
        {
            this.nombreSerVivo = nombre;
        }

        // Métodos
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por sí solas");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {this.nombreSerVivo}.");
        }
    }
}
