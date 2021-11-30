using System;
using System.Collections.Generic;
using System.IO;


public static class Analytics
{

    public static double FindGpa(List<Student> students)
    {
        double summ = 0.0;
        foreach (var stupid in students)
        {
            double stupidSumm = 0;
            foreach (var item in stupid.Grades)
            {
                stupidSumm += item;
            }
            stupidSumm = stupidSumm / stupid.Grades.Count;
            summ += stupidSumm;
        }
        double answ = summ / students.Count;
        return answ;
    }


    public static void WriteStudentsWithGpaNoLessThanAverage(List<Student> students, string path, double gpa)
    {
        string text = $"{gpa:f2}" + "\n";
        foreach (var stupid in students)
        {
            double stupidSumm = 0;
            foreach (var item in stupid.Grades)
            {
                stupidSumm += item;
            }
            if (stupidSumm /stupid.Grades.Count >= gpa)
            {
                text += stupid.Name + " " + stupid.LastName + " " + stupid.GroupNumber + "\n";
            }    
        }
        File.WriteAllText(path, text);
    }
}