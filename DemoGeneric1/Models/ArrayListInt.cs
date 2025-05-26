using System.Collections;

namespace DemoGeneric1.Models;

public class ArrayListInt
{
    private readonly ArrayList _arrayList;

    public ArrayListInt()
    {
        _arrayList = new ArrayList();
    }

    public void Add (int value)
    {
        _arrayList.Add(value);
    }
}
