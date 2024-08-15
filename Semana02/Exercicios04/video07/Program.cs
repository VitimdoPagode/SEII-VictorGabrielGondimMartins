//Conditional
using System.Runtime.CompilerServices;

var aquariumInventory = "puffer fish";

/*if(aquariumInventory == "puffer fish")
{
    Console.WriteLine("I will buy a puffer fish");
}
else if(aquariumInventory == "clown fish")
{
    Console.WriteLine("i will buy the clown fish");
}*/

if(aquariumInventory is string)
{
    Console.WriteLine("aquariumInventory is a string");
}

if(aquariumInventory == "clown fish" || aquariumInventory == "puffer fish")
{
    Console.WriteLine("i will buy the clown fish or a puffer fish");
}
else
{
    Console.WriteLine("i will not buy anything!");
}

var fishtankprice = 1000;

if(fishtankprice <= 1000)
{
    Console.WriteLine("i will buy the fish");
}
