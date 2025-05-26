using System.Collections;

namespace DemoGeneric1.Models;

public class ArrayListString
{
    private readonly ArrayList _arrayList;

    public ArrayListString()
    {
        _arrayList = new ArrayList();
    }

    public void Add(string value)
    {
        _arrayList.Add(value);
    }
}
