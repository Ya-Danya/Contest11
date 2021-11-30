using System;
using System.Runtime.Serialization;

[DataContract]
public class Soup
{
    [DataMember]
    public bool WillEat = true;

    public Soup(Ingredient[] ingredients)
    {
        foreach (var item in ingredients)
        {
            if (item is Meat)
            {
                if ((item as Meat).IsTasty == false)
                {
                    WillEat = false;
                }
            }
            else
            {
                if ((item as Vegetable).IsAllergicTo == true)
                {
                    WillEat = false;
                }
            }
        }
    }
}