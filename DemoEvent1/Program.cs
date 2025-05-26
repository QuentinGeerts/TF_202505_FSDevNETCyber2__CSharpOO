using DemoEvent1.Models;

CounterHandler counterHandler = new CounterHandler(10);

counterHandler.CounterAddMethod(4);
counterHandler.CounterAddMethod(4);
counterHandler.CounterAddMethod(1, () => { Console.WriteLine("Hello"); });
counterHandler.CounterAddMethod(10);
counterHandler.CounterAddMethod(1);


counterHandler.AdvancedCounterAddMethod(5);
counterHandler.AdvancedCounterAddMethod(5);