//Loops

for(var i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

string[] favoriteBands = ["Van Hallen", "Dokken", "Great White"];

for(var i = 0; i < favoriteBands.Length; i++)
{
    Console.WriteLine(favoriteBands[i]);
}

foreach(var band in favoriteBands)
{
    Console.WriteLine(band);
}

favoriteBands.ToList().ForEach((i) => {Console.WriteLine("ForEach: " + i);
});

Array.ForEach(favoriteBands, e => Console.WriteLine("Array.ForEach: " + e));