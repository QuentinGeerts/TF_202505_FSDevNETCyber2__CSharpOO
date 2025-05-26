namespace DemoStatic.Models;

// Classe static ne peut contenir QUE des membres statics
internal static class ClasseStatic
{
    public const int MaConstante = 0;

    public static int MyProperty { get; set; }

    public static void MaMethode()
    {

    }
}
