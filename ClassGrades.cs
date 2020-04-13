using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AverageGradesAfterRemovingLowestGrade
{
    class ClassGrades
    {
        List<string> gradesForEachStudent = new List<string>()
        {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
        };

        public List<int[]> ConvertStringsToIntArrays()
        {
            List<int[]> gradesAsInts = new List<int[]>();
            for (int i = 0; i < gradesForEachStudent.Count; i++)
            {
                var splitString = gradesForEachStudent[i].Split(",").Select(s => int.Parse(s)).ToArray();
                gradesAsInts.Add(splitString);
            }
            return gradesAsInts;
        }
    }
}
