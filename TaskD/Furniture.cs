using System;
using System.Xml.Serialization;

[XmlInclude(typeof(Lamp))]
[XmlInclude(typeof(Bed))]
[XmlInclude(typeof(Pillow))]
public abstract class Furniture
{
    [XmlElement("id")]
    public long Id;

    public Furniture() { }

    protected Furniture(long id)
    {
        Id = id;
    }
}