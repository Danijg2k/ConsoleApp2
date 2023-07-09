using AvisosVarios.Classes;

AvisosTrafico av1 = new AvisosTrafico();
av1.MostrarAviso();

AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madrid", "Sanción de velocidad: 300 $", "09-07-2023");
Console.WriteLine(av2.GetFecha());
av2.MostrarAviso();