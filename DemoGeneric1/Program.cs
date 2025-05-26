using DemoGeneric1.Models;

ArrayListInt arrayListInt = new ArrayListInt();

//arrayListInt.Add("Bonjour"); // Ne fonctionne pas
arrayListInt.Add(1);
arrayListInt.Add(2);
arrayListInt.Add(3);

ArrayListString arrayListString = new ArrayListString();

//arrayListString.Add(1); // Ne fonctionne pas 
arrayListString.Add("1");
arrayListString.Add("2");
arrayListString.Add("3");

ArrayListGen<int> arrayListGenInt = new ArrayListGen<int>();

arrayListGenInt.Add(1);
//arrayListGenInt.Add("Bonjour"); // Ne fonctionne

ArrayListGen<string> arrayListGenString = new ArrayListGen<string>();
ArrayListGen<object> arrayListGenObject = new ArrayListGen<object>();
