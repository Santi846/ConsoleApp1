//iterate a list
//implicit variable decalaration
var names = new[] { "Santi", "Felipe", "Emillia" };

foreach (var name in names)
{
    Console.WriteLine($"Hello, {name.ToUpper()}!");
}

//use a declared variable
//explicit variable decalaration
//reference decalaration
string nombre = "Santiago Arocha";
Console.WriteLine(nombre);

//value decalaration
int edad = 21;
float firstNum = -20.5f;
double secondNum = -70.5;
decimal thirdNum = 485.623m;

Console.WriteLine("Mi edad es: " + edad + "y mi primer numero es el: " + firstNum + "mi segundo numero es el:" + secondNum + " canto el numero:" + thirdNum);