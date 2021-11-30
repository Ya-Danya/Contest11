using System.Xml.Serialization;

public class Ash : Tree
{
    [XmlElement("leafCount")]
    public int LeafCount;

    public Ash() { }

    public Ash(int height, int age, int leafCount) : base(height, age)
    {
        LeafCount = leafCount;
    }

    public override string ToString() => $"Ash with {base.ToString()} leaf:{LeafCount}";
}