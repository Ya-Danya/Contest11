using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Deserializer
{
    public static BinaryFormatter formatter = new BinaryFormatter();
    public static List<Student> DeserializeStudents(string path)
    {
        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        {
            return (List<Student>)formatter.Deserialize(fs);
        }
    }
}