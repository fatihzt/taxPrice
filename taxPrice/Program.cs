using System;

Console.WriteLine("--Calculating Tax's Price--");


Console.WriteLine("Please enter a product price:");
var value1 = Console.ReadLine();
Console.WriteLine("Please enter a tax ratio:");
var value2 = Console.ReadLine();
if (string.IsNullOrEmpty(value1))
{
    Console.WriteLine("Please!!!enter a product price:");
    return;
}

if (int.TryParse(value1, out int x))
{
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine("Its not ınteger.");
    return;
}
if (string.IsNullOrEmpty(value2))
{
    Console.WriteLine("Please!!!enter a tax ratio.");
    return;
}
if (int.TryParse(value2, out int y))
{
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine("Its not integer.");
    return;
}

double number1 = Convert.ToDouble(value1);
double number2 = Convert.ToDouble(value2);
double taxprice = (number1 * number2 / 100 + number1);
Console.WriteLine(taxprice);
