using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Propiedades
{
    public class Class2
    {
        // Class properties
        private string? _firstName;
        private string? _lastName;
        private int _age;

        // Getters, Setters
        public string? FirstName
        {
            get { return _firstName; } 
            set { _firstName = value; }
        }

        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

    }
}
