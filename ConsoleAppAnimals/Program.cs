// See https://aka.ms/new-console-template for more information
using ConsoleAppAnimals;

Console.WriteLine("Hello, World!");

//Ajouter un animal dans la base

DatabaseAnimalsContext context = new DatabaseAnimalsContext();
context.Animals.Add(new Animal { Name = "Lion", Species = "Félin" });
context.SaveChanges();

foreach (var animal in context.Animals)
{
    Console.WriteLine(string.Format("{0} a pour espèce :    {1}", animal.Name, animal.Species));
}
