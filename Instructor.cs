using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_AggregationAndContainment_StephanieLopez
{
    internal class Instructor
    {
        //Fields
        string _firstName;
        string _lastName;

        //Constructor
        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        // Override ToString
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
