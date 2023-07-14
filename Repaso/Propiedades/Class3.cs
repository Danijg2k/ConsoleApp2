using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Propiedades
{
    public class Class3
    {
        // Class properties
        public string FirstName { get; private set; }
        public string SecondName { get; init; }

        // Builders
        public Class3(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }

        // Not allowed (only in object initializer or builder / init accessor)

        //public void cantChangeSecondName()
        //{
        //    SecondName = "dsda";
        //}


    }
}
