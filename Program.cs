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
void operateFunction()
{
    Console.WriteLine("How many operations you wish to perform: ");
    int counting_operations = int.Parse(Console.ReadLine());
    if (counting_operations != null)
    {
        for (int i = 0; i < counting_operations; i++)
        {   
            Console.WriteLine("What operation would you like to perform: ");
            var operation = Console.ReadLine();

            if (operation == "+" && operation != null)
            {
                Console.WriteLine("We will perform an operation, please enter your first number: ");
                var firstNumString = Console.ReadLine();
                var firstNum = int.Parse(firstNumString!);

                Console.WriteLine("We will perform an operation, please enter your second number: ");
                var secondNumString = Console.ReadLine();
                var secondNum = int.Parse(secondNumString!);

                var FirstSum = firstNum;
                FirstSum += secondNum;
                Console.WriteLine($"The sum result is: {FirstSum}");
            }
            else if (operation == "-" && operation != null)
            {
                Console.WriteLine("We will perform an operation, please enter your first number: ");
                var firstNumString = Console.ReadLine();
                var firstNum = int.Parse(firstNumString!);

                Console.WriteLine("We will perform an operation, please enter your second number: ");
                var secondNumString = Console.ReadLine();
                var secondNum = int.Parse(secondNumString!);

                var FirstResta = firstNum;
                FirstResta -= secondNum;
                Console.WriteLine($"The subtract result is: {FirstResta}");
                
            }
            else if (operation == "*" && operation != null)
            {
                Console.WriteLine("We will perform an operation, please enter your first number: ");
                var firstNumString = Console.ReadLine();
                var firstNum = int.Parse(firstNumString!);

                Console.WriteLine("We will perform an operation, please enter your second number: ");
                var secondNumString = Console.ReadLine();
                var secondNum = int.Parse(secondNumString!);

                var multiplicacion = firstNum * secondNum;
                Console.WriteLine($"The multiplication result is: {multiplicacion}");
                
            }
            else if (operation == "/" && operation != null)
            {
                Console.WriteLine("We will perform an operation, please enter your first number: ");
                var firstNumString = Console.ReadLine();
                var firstNum = int.Parse(firstNumString!);

                Console.WriteLine("We will perform an operation, please enter your second number: ");
                var secondNumString = Console.ReadLine();
                var secondNum = int.Parse(secondNumString!);

                var division = firstNum / secondNum;
                Console.WriteLine($"The division result is: {division}");
                
            }
            else
            {
                Console.WriteLine("You've entered a null character, type one plis");
                
            }

            

            
        }
    }
    else
    {
        Console.WriteLine("You've entered a null character, type one number plis");
        
    }

};

operateFunction();