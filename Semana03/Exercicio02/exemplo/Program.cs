//Array
string[] myArray = new string[7];

myArray[0] = "Segunda";
myArray[1] = "Terça";
myArray[2] = "Quarta";
myArray[3] = "Quinta";
myArray[4] = "Sexta";
myArray[5] = "Sábado";
myArray[6] = "Domingo";

Console.WriteLine(myArray[0]);
for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

//Lista
List<string> list = new List<string>();
list.Add("Segunda");
list.Add("Terça");
list.Add("Quarta");
list.Add("Quinta");
list.Add("Sexta");
list.Add("Sábado");
list.Add("Domingo");

for(int i = 0; i < list.Count; i++)
{
    list[i] = list[i].Substring(0, 3);
    Console.WriteLine(list[i]);
}

//Dicionário

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary[0] = "Segunda";
dictionary[1] = "Terça";
dictionary[2] = "Quarta";
dictionary[3] = "Quinta";
dictionary[4] = "Sexta";
dictionary[5] = "Sábado";
dictionary[6] = "Domingo";

for(int i = 0; i < dictionary.Count; i++)
{
    dictionary[i] = dictionary[i].Substring(0, 3);
    Console.WriteLine(dictionary[i]);
}