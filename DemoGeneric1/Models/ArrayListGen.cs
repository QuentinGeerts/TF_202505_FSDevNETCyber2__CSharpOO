using System.Collections;

namespace DemoGeneric1.Models;

internal class ArrayListGen<T>
{
    private readonly ArrayList _arrayList;

    public ArrayListGen()
    {
        _arrayList = new ArrayList();
    }

    public T this[int index]
    {
        get
        {
            return (T) _arrayList[index];
        }
        set
        {
            _arrayList[index] = value;
        }
    }

    public void Add(T value)
    {
        _arrayList.Add(value);
    }
}
