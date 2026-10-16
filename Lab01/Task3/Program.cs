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

static void SolveLinear(double a, double b)
{
    if (a == 0)
    {
        string result = b == 0 ? "nieskończenie wiele rozwiązań" : "brak rozwiązań";
        Console.WriteLine(b == 0 ? "Równanie tożsamościowe: " + result + "." : "Równanie sprzeczne: " + result + ".");
    }
    else
        Console.WriteLine($"Jedno rozwiązanie: x = {-b / a}");
}

double a = ReadCoefficient("a");
double b = ReadCoefficient("b");
double c = ReadCoefficient("c");
if (a == 0)
{
    Console.WriteLine("a = 0, więc równanie redukuje się do równania liniowego:");
    SolveLinear(b, c);
}
else
{
    double delta = b * b - 4 * a * c;
    Console.WriteLine($"Delta = {delta}");
    if (delta > 0)
    {
        double sqrtDelta = Math.Sqrt(delta);
        double x1 = (-b - sqrtDelta) / (2 * a);
        double x2 = (-b + sqrtDelta) / (2 * a);
        Console.WriteLine($"Dwa rozwiązania rzeczywiste: x1 = {x1}, x2 = {x2}");
    }
    else if (delta == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"Jedno rozwiązanie podwójne: x = {x}");
    }
    else
    {
        string result = delta < 0 ? "brak rozwiązań rzeczywistych" : "nie można określić rozwiązań";
        Console.WriteLine(result + ".");
    }
}
