using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    public abstract class Animales
    {
        // Métodos
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar.");
        }

        public abstract void GetNombre();
    }
}
