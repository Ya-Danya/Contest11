using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


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
}