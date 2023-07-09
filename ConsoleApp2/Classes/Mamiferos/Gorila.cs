using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes.Mamiferos
{
    public class Gorila : Mamifero
    {
        // Constructores
        public Gorila(string nombre) : base(nombre) { }

        // Métodos
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }
}
