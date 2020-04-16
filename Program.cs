using System;

namespace AverageGradesAfterRemovingLowestGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation();
            double average = sim.RunCode();
            Console.WriteLine(average);
            Console.ReadLine();
            
        }
    }
}
