using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AverageGradesAfterRemovingLowestGrade
{
    class Simulation
    {
        ClassGrades classGrades = new ClassGrades();

        public double RunCode()
        {
            List<double> averagesForEachStudent = new List<double>();
            double average;

            var intArray = classGrades.ConvertStringsToInts();
            foreach(List<int> grades in intArray)
            {
                classGrades.RemoveLowestGrade(grades);
                averagesForEachStudent.Add(grades.Average());
            }
            average = averagesForEachStudent.Average();
            return average;
        }
    }
}
