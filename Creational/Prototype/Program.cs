/*
 * Create object based on an existing object through cloning.
 * When an object is required that is similar to existing object or when the creation would be expensive as compared to cloning.
*/
using Prototype;

var original = new Sheep("Jolly", "Mountain Sheep");
Console.WriteLine(original.Name); // Jolly
Console.WriteLine(original.Category); // Mountain Sheep

var cloned = original.Clone();
cloned.Name = "Dolly";
Console.WriteLine(cloned.Name); // Dolly
Console.WriteLine(cloned.Category); // Mountain Sheep
Console.WriteLine(original.Name); // Jolly