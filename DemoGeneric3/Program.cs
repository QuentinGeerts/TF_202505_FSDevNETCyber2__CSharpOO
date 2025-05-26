
// 1. Action<>
// → Aucun retour

using DemoGeneric3.Models;

Action<double, double> operations = null;
operations += Addition;
operations += (double a, double b) => { Console.WriteLine($"{a} - {b} = {a - b}"); };

operations?.Invoke(5, 3);

// 2. Func<>
// → Retourne une valeur d'un type défini génériquement
Func<double, double, double> operations2 = null;
operations2 += Multiplication;
operations2 += (double a, double b) => a / b;


// 3. Predicate<>
// → Retourne une valeur d'un type booléen
Predicate<int> isPrimePredicate = (int x) =>
{
    for (int i = 2; i <= Math.Sqrt(x); i++)
    {
        if (x % i == 0) return false;
    }

    return true;
};


for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"{i}: {isPrimePredicate?.Invoke(i)}");
}


static void Addition (double a, double b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static double Multiplication (double a, double b)
{
    return a * b;
}


Person[] people = [
    new Person { Firstname = "Quentin", Lastname = "Geerts", Age = 29, Sex = Sex.M },
    new Person { Firstname = "Michael", Lastname = "Person", Age = 40, Sex = Sex.M },
    new Person { Firstname = "Mélanie", Lastname = "Geerts", Age = 37, Sex = Sex.F },
    new Person { Firstname = "Caroline", Lastname = "Herssens", Age = 40, Sex = Sex.F },
    new Person { Firstname = "Jean", Lastname = "Dupont", Age = 15, Sex = Sex.M },
];



static Person[] getOnlyMen(Person[] people)
{
    List<Person> result = new List<Person>();

    foreach (Person person in people)
    {
        if (person.Sex == Sex.M) result.Add(person);
    }

    return result.ToArray();
}

static Person[] getOnlyWomen(Person[] people)
{
    List<Person> result = new List<Person>();

    foreach (Person person in people)
    {
        if (person.Sex == Sex.F) result.Add(person);
    }

    return result.ToArray();
}

static Person[] getOnlyAdult(Person[] people)
{
    List<Person> result = new List<Person>();

    foreach (Person person in people)
    {
        if (isAdult(person)) result.Add(person);
    }

    return result.ToArray();
}

static bool isAdult (Person person)
{
    return person.Age >= 18;
}



static Person[] Filter(Person[] people, Predicate<Person> predicate)
{
    List<Person> result = new List<Person>();

    if (predicate == null) return result.ToArray();

    foreach (Person person in people)
    {
        //if (predicate != null && predicate.Invoke(person)) result.Add(person);
        if (predicate(person)) result.Add(person);
    }

    return result.ToArray();
}

Person[] Adults = Filter(people, isAdult);
Person[] onlyWomen = Filter(people, (person) =>  person.Sex == Sex.F);

List<Person> persons = new List<Person>();
Person[] onlyMen = persons.FindAll((person) => person.Sex == Sex.M).ToArray();