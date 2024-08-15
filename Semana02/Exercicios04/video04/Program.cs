//Create
using System.Text;

string petFish = "puffer fish";

//Concatenation
petFish  = "porcupine " + petFish;

Console.WriteLine($"I AM BUYING {petFish}!!!!!");

//Read
Console.WriteLine(petFish);

//Update
string newPetFish = petFish.Replace("porcupine", "blue dot");
Console.WriteLine(newPetFish);

//Delete - string builder
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);

newCrustacean.Remove(0, 8);
Console.WriteLine(newCrustacean);
