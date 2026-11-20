using static Algorytmy;
Check(6d, PoleTrojkata(4, 3), "trójkąt 4x3"); Check(0d, PoleTrojkata(0, 3), "trójkąt z zerem");
Throws<ArgumentOutOfRangeException>(() => PoleTrojkata(-1, 3), "ujemny wymiar"); Throws<ArgumentException>(() => PoleTrojkata(double.PositiveInfinity, 3), "nieskończoność");
Check(4d, Srednia([2, 4, 6]), "średnia"); Check(8d, Srednia([8]), "średnia jednoelementowa"); Throws<ArgumentException>(() => Srednia([]), "pusta lista");
Check(120L, Silnia(5), "silnia"); Check(1L, Silnia(0), "silnia zera"); Throws<ArgumentOutOfRangeException>(() => Silnia(-1), "ujemna silnia");
Check(6L, Nwd(18, 24), "NWD"); Check(9L, Nwd(0, 9), "NWD z zerem"); Throws<ArgumentException>(() => Nwd(0, 0), "NWD dwóch zer");
Check(true, CzyPierwsza(17), "17"); Check(true, CzyPierwsza(3), "3 pierwsza"); Check(false, CzyPierwsza(4), "4 złożona"); Check(false, CzyPierwsza(25), "25 złożona"); Check(false, CzyPierwsza(-7), "liczba ujemna");
Console.WriteLine("Wszystkie kontrole zakończyły się powodzeniem.");
static void Check<T>(T e, T a, string n) { if (!EqualityComparer<T>.Default.Equals(e, a)) throw new InvalidOperationException($"{n}: oczekiwano {e}, otrzymano {a}."); }
static void Throws<T>(Action f, string n) where T : Exception { try { f(); } catch (T) { return; } throw new InvalidOperationException($"{n}: brak wyjątku {typeof(T).Name}."); }
