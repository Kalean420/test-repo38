using System.Globalization;

static double ReadNumber(int index)
{
    while (true)
    {
        Console.Write($"Podaj liczbę {index}/5: ");
        string? input = Console.ReadLine();
        if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double value) && double.IsFinite(value))
            return value;
        Console.WriteLine("Błąd: wpisz poprawną, skończoną liczbę.");
    }
}

Console.WriteLine("Zadanie 1 — pięć liczb ściśle rosnących");
double previous = ReadNumber(1);
for (int i = 2; i <= 5; i++)
{
    double current = ReadNumber(i);
    if (current <= previous)
    {
        Console.WriteLine($"Błąd: liczba {current} nie jest większa od {previous}.");
        Console.WriteLine("Program zakończony.");
        return;
    }
    previous = current;
}
Console.WriteLine("Sukces! Wszystkie pięć liczb tworzy ciąg ściśle rosnący.");
