using ConsoleApp2.Classes;
using ConsoleApp2.Classes.Mamiferos;
using ConsoleApp2.Interfaces;

// 1. Interfaces
//Caballo babieca = new Caballo("Babieca");
//// NumeroPatas IMamiferosTerrestres
//IMamiferosTerrestres mamiferoTerrestre = babieca;
//Console.WriteLine($"Núm patas andar babieca: {mamiferoTerrestre.NumeroPatas()}.");

//// NumeroPatas ISaltoConPatas
//ISaltoConPatas saltoConPatas = babieca;
//Console.WriteLine($"Núm patas salto babieca: {saltoConPatas.NumeroPatas()}.");



// 2. Clases abstractas
Lagartija juancho = new Lagartija("Juancho");
juancho.GetNombre();
juancho.Respirar();

Humano juan = new Humano("Juan");
juan.GetNombre();