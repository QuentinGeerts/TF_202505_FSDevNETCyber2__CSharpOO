namespace DemoGeneric3.Models;

public enum Sex
{
    F,
    M
}

public class Person
{
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public int Age { get; set; }
    public Sex Sex { get; set; }
}
