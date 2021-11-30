using System;
using System.Xml.Serialization;

public class Lamp : Furniture
{
    [XmlElement("lifeTime")]
    public long LifeTimeSeconds;

    public Lamp() { }

    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        LifeTimeSeconds = (long)lifeTime.TotalSeconds;
    }    
}