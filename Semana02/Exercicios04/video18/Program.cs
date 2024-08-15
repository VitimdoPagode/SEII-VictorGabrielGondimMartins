//records
Person person1 = new("Vitim", "Gabriel");
Person person2 = new("Vitim", "Gabriel");

// person1.LastName = "gabriel";

Console.WriteLine(person1 == person2);

Person person3 = person2 with {LastName = "junior"};
Console.WriteLine(person3.ToString());
public record Person(string FirstName, string LastName);

