using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

public class SimpleFurnitureSerializer
{
    public void Serialize(List<Furniture> furniture, string outputPath)
    {
        var serializer = new XmlSerializer(typeof(Furniture[]));
        using var fs = new FileStream(outputPath, FileMode.OpenOrCreate);
        serializer.Serialize(fs, furniture.ToArray());
    }
}