using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

[DataContract]
[KnownType(typeof(Meat))]
[KnownType(typeof(Vegetable))]
public class Ingredient : IComparable<Ingredient>
{
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    protected int TimeToCook { get; set; }

    public int CompareTo([AllowNull] Ingredient other)
    {
        if (TimeToCook < other.TimeToCook)
        {
            return 1;
        }
        else if (TimeToCook > other.TimeToCook)
        {
            return -1;
        }
        return 0;
    }

    public override string ToString() => Name;

    public Ingredient(string name, int timeToCook)
    {
        Name = name;
        TimeToCook = timeToCook;
    }
}