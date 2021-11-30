using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Bed : Furniture
{
    [XmlElement("pillow")]
    public List<Pillow> Pillows;

    public Bed() { }

    public Bed(long id, List<Pillow> pillows) : base(id)
    {
        Pillows = pillows;
    }
}