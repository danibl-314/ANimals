using System;

class Program
{
    static void Main(string[] args)
    {
        Pato lucas = new Pato();
        Ballena willy = new Ballena();
        Gato garfield = new Gato();
        Perro scooby = new Perro();
        Conejo bugs = new Conejo();

        Console.WriteLine("--- Pruebas con la Ballena ---");
        willy.Comer(); 
        willy.Nadar(); 
        
        Console.WriteLine(); 

        Console.WriteLine("--- Pruebas con el Pato ---");
        lucas.Comer(); 
        lucas.Volar(); 
        lucas.Graznar(); 
        
        Console.WriteLine();

        Console.WriteLine("--- Pruebas con el Gato ---");
        garfield.Comer(); // Hereda de Animal
        garfield.Maullar(); // Método propio de Gato
        
        Console.WriteLine();

        Console.WriteLine("--- Pruebas con el Perro ---");
        scooby.Comer(); // Hereda de Animal
        scooby.Ladrar(); // Método propio de Perro
        
        Console.WriteLine();

        Console.WriteLine("--- Pruebas con el Conejo ---");
        bugs.Comer(); // Hereda de Animal
        bugs.Saltar(); // Método propio de Conejo
    }
}