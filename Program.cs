//iterate a list
//implicit variable decalaration
using System.Text.RegularExpressions;

//var names = new[] { "Santi", "Felipe", "Emillia" };

//foreach (var name in names)
//{
//    Console.WriteLine($"Hello, {name.ToUpper()}!");
//}

//use a declared variable
//explicit variable decalaration
//reference decalaration
//string nombre = "Santiago Arocha";


//value decalaration
//int edad = 21;
//float firstNum = -20.5f;
//double secondNum = -70.5;
//decimal thirdNum = 485.623m;

//nombre = "Santiago";

//const int mate = 1;
//Console.WriteLine("Mi edad es: " + edad + "y mi primer numero es el: " + firstNum + "mi segundo numero es el:" + secondNum + " canto el numero:" + thirdNum);
//Console.WriteLine("Mi nombre es: " + nombre + ", y estoy tomando " + mate + " mate");

Console.WriteLine("Que opereacion desea realizar: ");
var operation = Console.ReadLine();

Console.WriteLine("Realizaremos una operacion, por favor ingrese su primer numero: ");
var firstNumString = Console.ReadLine();
var firstNum = int.Parse(firstNumString!);

Console.WriteLine("Realizaremos una operacion, por favor ingrese su segundo numero: ");
var secondNumString = Console.ReadLine();
var secondNum = int.Parse(secondNumString!);


if (operation == "+")
{
    var sum = firstNum + secondNum;
    Console.WriteLine($"El resultado de la suma es: {sum}");
}
else if (operation == "-")
{
    var resta = firstNum - secondNum;
    Console.WriteLine($"El resultado de la resta es: {resta}");
}
else if (operation == "*")
{
    var multiplicacion = firstNum * secondNum;
    Console.WriteLine($"El resultado de la multiplicacion es: {multiplicacion}");
}
else if (operation == "/")
{
    var division = firstNum / secondNum;
    Console.WriteLine($"El resultado de la division es: {division}");
}
else
{
    Console.WriteLine("Error");
}