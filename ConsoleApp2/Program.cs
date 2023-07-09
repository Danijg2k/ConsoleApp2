using ConsoleApp2.Classes.Mamiferos;
using ConsoleApp2.Interfaces;

Ballena wally = new Ballena("Wally");
wally.Nadar();

Caballo babieca = new Caballo("Babieca");
// NumeroPatas IMamiferosTerrestres
IMamiferosTerrestres mamiferoTerrestre = babieca;
Console.WriteLine($"Núm patas andar babieca: {mamiferoTerrestre.NumeroPatas()}.");

// NumeroPatas ISaltoConPatas
ISaltoConPatas saltoConPatas = babieca;
Console.WriteLine($"Núm patas salto babieca: {saltoConPatas.NumeroPatas()}.");
