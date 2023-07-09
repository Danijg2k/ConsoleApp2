using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes.Mamiferos
{
    public class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        // Constructores
        public Caballo(string nombre) : base(nombre) { }


        // Métodos
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico()
        {
            return true;
        }

    }
}
