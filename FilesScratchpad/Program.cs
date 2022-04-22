


using FilesScratchpad;
using System.Text.Json;

//Person fred = new Person();
//fred.Name = "Fred";
//Person wilma = new Person();
//wilma.Name = "Wilma";

//Dog rex = new Dog();
//rex.Owner = fred;
//rex.Name = "Rex";

//Dog spot = new Dog();
//spot.Owner = wilma;
//spot.Name = "Spot";

//List<Dog> dogs = new List<Dog> { rex, spot};

//JsonSerializerOptions options = new JsonSerializerOptions
//{
//    WriteIndented = true,
//};
//string dogsJson = JsonSerializer.Serialize(dogs, options);

//using (FileStream fs = File.OpenWrite(@"C:\Users\erich\dogs.json"))
//using (TextWriter writer = new StreamWriter(fs))
//{
//    writer.Write(dogsJson);
//}

string dogsJson = File.ReadAllText(@"C:\Users\erich\dogs.json");
List<Dog> dogs = JsonSerializer.Deserialize<List<Dog>>(dogsJson);

Console.WriteLine(dogs.Count);



//using (FileStream fs = File.Open(@"C:\Users\erich\MyTestFile.txt", FileMode.Create))
//using (TextWriter writer = new StreamWriter(fs))
//{
//    writer.WriteLine("Avocado");
//    writer.WriteLine("Grapefruit");
//}
    
//using (FileStream fs = File.OpenRead(@"C:\Users\erich\MyTestFile.txt"))
//using (TextReader reader = new StreamReader(fs))
//{
//    string contents = reader.ReadToEnd();
//}

//string[] lines = File.ReadAllLines(@"C:\Users\erich\MyTestFile.txt");

Console.WriteLine("Done");