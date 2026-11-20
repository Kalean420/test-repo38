Console.WriteLine("Scenariusz debuggera: liczby ujemne");
int[] values = [-8, -3, -12, -5];
int total = CalculateTotal(values), maximum = FindMaximum(values);
double average = CalculateAverage(total, values.Length);
Console.WriteLine($"Suma: {total}"); Console.WriteLine($"Maksimum: {maximum}"); Console.WriteLine($"Średnia: {average:0.00}");
static int CalculateTotal(int[] values) { int total = 0; foreach (int value in values) total += value; return total; }
static int FindMaximum(int[] values) { ArgumentNullException.ThrowIfNull(values); if (values.Length == 0) throw new ArgumentException("Tablica nie może być pusta.", nameof(values)); int max = values[0]; for (int i = 1; i < values.Length; i++) if (values[i] > max) max = values[i]; return max; }
static double CalculateAverage(int total, int count) { if (count <= 0) throw new ArgumentOutOfRangeException(nameof(count)); return (double)total / count; }
