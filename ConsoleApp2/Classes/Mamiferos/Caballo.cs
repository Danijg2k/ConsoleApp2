using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes.Mamiferos
{
    public class Caballo : Mamifero, IMamiferosTerrestres
    {
        // Constructores
        public Caballo(string nombre) : base(nombre) { }

        // Métodos
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }
}
