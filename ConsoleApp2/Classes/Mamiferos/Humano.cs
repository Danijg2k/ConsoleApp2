using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes.Mamiferos
{
    public class Humano : Mamifero
    {
        // Constructores
        public Humano(string nombre) : base(nombre) { }

        // Métodos
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
}
