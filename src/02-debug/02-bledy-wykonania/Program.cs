using System.Diagnostics;
using System.Globalization;
bool invalidDemo = args.Contains("--demo-invalid", StringComparer.OrdinalIgnoreCase);
string[] scores = invalidDemo ? ["4", "x", "3"] : ["4", "5", "3"];
Console.WriteLine("Scenariusz błędów wykonania");
try { Console.WriteLine($"Średnia ocen: {CalculateAverage(scores):0.00}"); }
catch (FormatException ex) { LogError("Niepoprawna ocena", ex); }
try { Console.WriteLine($"10 / 2 = {Divide(10, 2)}"); }
catch (ArgumentException ex) { LogError("Błędne dzielenie", ex); }
string report = BuildReport("debugger", 3); Debug.Assert(report.Length > 0, "Raport nie może być pusty"); Console.WriteLine(report);
static bool TryReadNumber(string text, out int value) => int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value);
static double Divide(int n, int d) { if (d == 0) throw new ArgumentException("Mianownik nie może być zerem.", nameof(d)); return (double)n / d; }
static double CalculateAverage(string[] values) { ArgumentNullException.ThrowIfNull(values); if (values.Length == 0) throw new ArgumentException("Lista nie może być pusta.", nameof(values)); int total = 0; foreach (string s in values) { if (!TryReadNumber(s, out int value)) throw new FormatException($"Niepoprawna liczba: '{s}'."); total += value; } return (double)total / values.Length; }
static string BuildReport(string topic, int count) { if (string.IsNullOrWhiteSpace(topic)) throw new ArgumentException("Temat nie może być pusty.", nameof(topic)); if (count < 0) throw new ArgumentOutOfRangeException(nameof(count)); return $"Temat: {topic}; znalezionych problemów: {count}"; }
static void LogError(string message, Exception ex) { Console.Error.WriteLine($"[ERROR] {DateTime.UtcNow:O} {message}"); Console.Error.WriteLine(ex); }
