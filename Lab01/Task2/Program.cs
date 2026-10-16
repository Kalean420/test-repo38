using System.Globalization;

static double ReadCoefficient(string name)
{
    while (true)
    {
        Console.Write($"Podaj współczynnik {name}: ");
        if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.CurrentCulture, out double value) && double.IsFinite(value))
            return value;
        Console.WriteLine("Błąd: wpisz poprawną, skończoną liczbę.");
    }
}

double a = ReadCoefficient("a");
double b = ReadCoefficient("b");
Console.WriteLine($"Równanie: {a} * x + {b} = 0");
if (a == 0)
{
    string result = b == 0 ? "nieskończenie wiele rozwiązań" : "brak rozwiązań";
    Console.WriteLine(b == 0 ? "Równanie tożsamościowe: " + result + "." : "Równanie sprzeczne: " + result + ".");
}
else
{
    double x = -b / a;
    Console.WriteLine($"Jedno rozwiązanie: x = {x}");
}
