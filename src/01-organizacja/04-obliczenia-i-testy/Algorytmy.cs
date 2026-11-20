public static class Algorytmy
{
    public static double PoleTrojkata(double podstawa, double wysokosc)
    {
        if (!double.IsFinite(podstawa) || !double.IsFinite(wysokosc)) throw new ArgumentException("Wymiary muszą być skończone.");
        if (podstawa < 0 || wysokosc < 0) throw new ArgumentOutOfRangeException(nameof(podstawa), "Wymiary nie mogą być ujemne.");
        return podstawa * wysokosc / 2;
    }
    public static double Srednia(IReadOnlyList<double> values)
    {
        ArgumentNullException.ThrowIfNull(values);
        if (values.Count == 0) throw new ArgumentException("Lista nie może być pusta.", nameof(values));
        double sum = 0;
        foreach (var value in values) { if (!double.IsFinite(value)) throw new ArgumentException("Wartości muszą być skończone.", nameof(values)); sum += value; }
        return sum / values.Count;
    }
    public static long Silnia(int n) { if (n < 0 || n > 20) throw new ArgumentOutOfRangeException(nameof(n)); long r = 1; for (int i = 2; i <= n; i++) r *= i; return r; }
    public static long Nwd(int x, int y) { long a = Math.Abs((long)x), b = Math.Abs((long)y); if (a == 0 && b == 0) throw new ArgumentException("NWD dwóch zer nie jest określone."); while (b != 0) (a, b) = (b, a % b); return a; }
    public static bool CzyPierwsza(int n) { if (n < 2) return false; for (int d = 2; d <= n / d; d++) if (n % d == 0) return false; return true; }
}
