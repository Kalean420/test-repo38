static int Calculate(int value) => 2 * value + 3;
foreach (int value in new[] { 4, -2 }) Console.WriteLine($"f({value}) = {Calculate(value)}");
