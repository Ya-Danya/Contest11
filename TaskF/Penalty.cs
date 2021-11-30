using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Penalty
{
    [DataMember]
    public int carNumber;
    [DataMember]
    public int cost;

    public Penalty(int carNumber, int cost)
    {
        this.carNumber = carNumber;
        this.cost = cost;
    }
}