using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_AggregationAndContainment_StephanieLopez
{
    internal class SchoolProgram
    {
        //Fields
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; // This is the Aggregation
        List<Student> _classRoster; //This is the Containment

        //Constructor
        public SchoolProgram(string ClassName, string ClassNumber, string RoomNumber, Instructor instructor)
        {
            _className = ClassName;
            _classNumber = ClassNumber;
            _roomNumber = RoomNumber;
            _instructor = instructor;
            _classRoster = new List<Student>();
        }

        //Properties
        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        public Instructor Instructor { get => _instructor; set => _instructor = value; }
        public List<Student> ClassRoster { get => _classRoster; }

        //Methods
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            Student newStudent = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classRoster.Add(newStudent);
        }

        // Override ToString
        public override string ToString()
        {
            return $"{ClassName} {ClassNumber} - {RoomNumber} - {_instructor.ToString()} - Number of Students: {_classRoster.Count}";
        }
    }
}
