using System;
using System.Collections.Generic;

public class Map<TKey, TValue>
{
    private List<(TKey, TValue)> map;

    public Map()
    {
        map = new List<(TKey, TValue)>();
    }

    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
        {
            throw new ArgumentException($"An item with the same key has already been added. Key: {key}");
        }
        else
        {
            map.Add((key, value));
        }
    }

    public TValue this[TKey key]
    {
        get
        {
            foreach (var item in map)
            {
                if (item.Item1.Equals(key))
                {
                    return item.Item2;
                }
            }
            throw new ArgumentException($"The given key '{key}' was not present in the map.");
        }
    }

    public bool Remove(TKey key)
    {
        if (ContainsKey(key))
        {
            return map.Remove((key, this[key]));
        }
        else
        {
            return false;
        }
    }

    public int Count => map.Count;

    public bool ContainsKey(TKey key)
    {
        bool k = false;
        foreach (var item in map)
        {
            if (item.Item1.Equals(key))
            {
                k = true;
            }
        }
        return k;
    }
}