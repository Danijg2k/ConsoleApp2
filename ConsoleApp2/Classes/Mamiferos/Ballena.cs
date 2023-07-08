using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes.Mamiferos
{
    public class Ballena : Mamifero
    {
        // Constructores
        public Ballena(string nombre) : base(nombre) { }

        // Métodos
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
