using System;
using System.Xml.Serialization;

public class Pillow : Furniture
{
    [XmlElement("isRuined")]
    public string IsRuinedString;

    public Pillow() { }

    public Pillow(long id, bool isRuined) : base(id)
        => IsRuinedString = isRuined ? "Yes" : "No";
}