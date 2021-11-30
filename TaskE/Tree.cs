using System;
using System.Xml.Serialization;

[XmlInclude(typeof(Oak))]
[XmlInclude(typeof(Ash))]
public class Tree : IComparable<Tree>
{
    [XmlElement("height")]
    public int Height;

    [XmlElement("age")]
    public int Age;

    public Tree() { }

    public Tree(int height, int age)
    {
        Age = age;
        Height = height;
    }

    public override string ToString() => $"height:{Height} age:{Age}";

    public int CompareTo(Tree tree)
    {
        int jopa = 0;
        if (Height > tree.Height)
        {
            jopa = 1;
        }
        else if (Height < tree.Height)
        {
            jopa = -1;
        }
        else
        {
            jopa = 0;
        }
        return jopa;
    }
}