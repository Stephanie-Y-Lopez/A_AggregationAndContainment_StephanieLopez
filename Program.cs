namespace A_AggregationAndContainment_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        static void Main(string[] args)
        {
            //Creating an instance
            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            
            // Add students
            prog124.AddStudent("Ana", "Mendes", 100, 100);
            prog124.AddStudent("Stephanie", "Lopez Chavoya", 95, 85);
            prog124.AddStudent(new Student("Nelly", "Gonzales", 86, 91));
            prog124.AddStudent(new Student("Oswaldo", "Lopez", 93, 99));

            // Display information
            Console.WriteLine(prog124.ToString());
            Console.WriteLine($"Instructor: {will.ToString()}");
            foreach (var student in prog124.ClassRoster)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}