using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Loop<T> : IEnumerable<T>
{
    public List<T> list = new List<T>();

    public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public Loop() { }

    public Loop(IEnumerable<T> sourсe) { }

    public void Add(T item)
    {
        this.list.Add(item);
    }

    public void Left()
    {
        T buff = list[0];
        for (int i = 0; i < this.list.Count - 1; i++)
        {
            list[i] = list[i + 1];
        }
        list[list.Count - 1] = buff;
    }

    public void Rigth()
    {
        T buff = list[list.Count - 1];
        for (int i = list.Count - 1; i > 0; i--)
        {
            list[i] = list[i - 1];
        }
        list[0] = buff;
    }

    public T PopOut()
    {
        T pop = list[0];
        list.RemoveAt(0);
        return pop;
    }

    public T ShowFirst()
    {
        return list[0];
    }
}
