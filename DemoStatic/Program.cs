using DemoStatic.Models;

// Instanciation = Création d'une nouvelle instance en mémoire
MaClasse variable1 = new MaClasse(); // Création d'une première instance
MaClasse variable2 = new MaClasse(); // Création d'une deuxième instance

variable1.ProprieteInstance = 42; // Utilisable sur une instance
variable2.ProprieteInstance = 10;

Console.WriteLine($"v1: {variable1.ProprieteInstance}"); // 42
Console.WriteLine($"v2: {variable2.ProprieteInstance}"); // 10

variable1.MethodeInstance();
variable2.MethodeInstance();


Console.WriteLine($"MaClasse: {MaClasse.ProprieteClasse}"); // 100
MaClasse.MethodeClasse();

// Instanciation impossible d'une classe static
// → Car une classe static ne peut pas avoir de membres d'instances
// → Aucun intérêt à instancier la classe
// ClasseStatic classeStatic = new ClasseStatic();

ClasseStatic.MyProperty = 42;
ClasseStatic.MaMethode();
Console.WriteLine($"Constante: {ClasseStatic.MaConstante}");