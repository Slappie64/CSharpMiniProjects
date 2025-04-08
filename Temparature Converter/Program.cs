using System.Security.Cryptography;

Console.WriteLine("Please enter a function to call (1-4):");
Console.WriteLine("1. Fahrenheit To Celsius");
Console.WriteLine("2. Celsius To Fahrenheit");
Console.Write("User Selection: ");

var UserSelection = Console.ReadLine();

switch (UserSelection)
{
    case "1": case "Fahrenheit To Celsius":
        Console.WriteLine(FahrenheitToCelsius());
        break;
    case "2": case "Celsius To Fahrenheit":
        Console.WriteLine(CelsiusToFahrenheit());
        break;
}


string FahrenheitToCelsius()
{
    Console.Write("Please enter a tempurature in Fahrenheit: ");
    double Fahrenheit = Convert.ToDouble(Console.ReadLine());

    double Celsius = (Fahrenheit - 32) * 5 / 9;
    return $"The temperature in Celsius is {Celsius} degrees.";
}

string CelsiusToFahrenheit()
{
    Console.Write("Please enter a tempurature in Celsius: ");
    double Celsius = Convert.ToDouble(Console.ReadLine());

    double Fahrenheit = (Celsius * 9 / 5) + 32;
    return $"The temperature in Fahrenheit is {Fahrenheit} degrees.";
}