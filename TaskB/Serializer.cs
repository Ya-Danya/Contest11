using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Serializer
{
    public static void ReadStudents(string path)
    {
        string[] info = File.ReadAllLines(path);
        for (int i = 0; i < info.Length; i++)
        {
            students.Add(Student.Create(info[i]));
        }
    }

    public static BinaryFormatter formatter = new BinaryFormatter();
    public static List<Student> students = new List<Student>();

    public static void SerializeStudents(string path)
    {
        Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None); 
        formatter.Serialize(stream, students);
        stream.Close();
    }
}