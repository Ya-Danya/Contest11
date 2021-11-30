using System;

public class MartianInt
{
    
    private static int count = 0;
    
    public MartianInt(int value)
    {
        this.Value = value;
    }

    public int Value;

    public static implicit operator MartianInt(int number)
    {
        int pivo = number - count;
        count++;
        if (pivo < 0)
        {
            throw new ArgumentException("Value is negative");
        }
        return new MartianInt(pivo);
    }

    public static explicit operator int(MartianInt number)
    {
        int pivo = number.Value + count;
        count++;
        return pivo;
    }
}