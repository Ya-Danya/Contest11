using System;
using System.Collections.Generic;

[Serializable]
public class Student
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public int GroupNumber { get; private set; }
    public List<int> Grades { get; private set; }

    public Student(string name, string lastName, int groupNumber, List<int> grades)
    {
        Name = name;
        LastName = lastName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public static Student Create(string studentInfo)
    {
        string[] infa = studentInfo.Split(' ');
        List<int> ocenki = new List<int>();
        for (int i = 3; i < infa.Length; ++i)
            ocenki.Add(Convert.ToInt32(infa[i]));
        return new Student(infa[0], infa[1], Convert.ToInt32(infa[2]), ocenki);
    }
}