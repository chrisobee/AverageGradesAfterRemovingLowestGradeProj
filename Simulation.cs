using System;
using System.Collections.Generic;
using System.Text;

namespace AverageGradesAfterRemovingLowestGrade
{
    class Simulation
    {
        ClassGrades classGrades = new ClassGrades();

        public void RunCode()
        {
            Func<double> average = classGrades.GetAverageGrades;
            var intArray = classGrades.ConvertStringsToIntArrays();
            foreach(List<int> grades in intArray)
            {
                classGrades.RemoveLowestGrade(grades);
            }
        }
    }
}
