//iterate a list
//implicit variable decalaration
var names = new[] { "Santi", "Felipe", "Emillia" };

foreach (var name in names)
{
    Console.WriteLine($"Hello, {name.ToUpper()}!");
}

//use a declared variable
//explicit variable decalaration
string nombre = "Santiago Arocha";
Console.WriteLine(nombre);