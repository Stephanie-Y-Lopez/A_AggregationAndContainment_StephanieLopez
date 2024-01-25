using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_AggregationAndContainment_StephanieLopez
{
    //Stephanie Lopez
    internal class Student
    {
        //Fields
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        //Constructor
        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        //Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        // Override ToString
        public override string ToString()
        {
            return $"{FirstName} {LastName} - CSI Grade {_csiGrade} - GenEd Grade {_genEdGrade}";
        }
    }
}
