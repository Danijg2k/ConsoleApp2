
using Linq.Extensions;
using Linq.Utilities;

var rand = new Random();
var math = new MathFunctions();

// Arrays / listas utilizados
string[] names = { "Tom", "Dick", "Harry" };
var randomInts = new List<int>();
var ints = new List<int> { 1,2,3,4,5 };

for(int i = 0; i < 10; i++)
{
    randomInts.Add(rand.Next(100));
}


// Ejercicios intro
names.Where(n => n.Length > 3)
    .Show("Longitud > 3");

randomInts.Where(x => math.IsPrime(x))
    .Show("Números primos");

randomInts.Sum(x => x)
    .Show("Suma elementos");

randomInts.Select(x => Math.Pow(x, 2))
    .Show("Cuadrados");

var primes = randomInts.Where(x => math.IsPrime(x))
    .ToArray();
primes.Show("Lista nueva con primos");

randomInts.Where(x => x > 50)
    .Average()
    .Show("Media de números > 50");

randomInts.Take(3)
    .Show("Primeros 3 elementos");

randomInts.Skip(3)
    .Show("Todos excepto 3 primeros");

randomInts.Reverse();

randomInts.Show("Reversed");

// Pares e impares contar
var pares = 0;
var impares = 0;

randomInts.ForEach(x =>
{
    if (x % 2 == 0) pares++;
    else if (x % 2 == 1) impares++;
});

randomInts.Where(x => x % 2 == 0).Count().Show("Números pares");
randomInts.Where(x => x % 2 == 1).Count().Show("Números impares");


// SQL Syntax
var names4 = from name in names
where name.Length > 4
select name;

names4.Show("Nombres longitud > 4");

// LinqPad exercises / examples
randomInts.ElementAt(1);
randomInts.Show("randomInts");
randomInts.Concat(ints).Show("randomInts concat ints");
randomInts.Union(ints).Show("randomInts union ints");