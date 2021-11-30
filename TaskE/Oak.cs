using System.Xml.Serialization;

public class Oak : Tree
{
    [XmlElement("acornCount")]
    public int AcornCount;


    public Oak(int height, int age, int acornCount) : base(height, age)
    {
        AcornCount = acornCount;
    }

    public Oak() { }

    public override string ToString() => $"Oak with {base.ToString()} acorn:{AcornCount}";
}