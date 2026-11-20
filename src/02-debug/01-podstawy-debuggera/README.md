# Podstawy debuggera

Uruchom `dotnet run --project src/02-debug/01-podstawy-debuggera/DebugowaniePodstaw.csproj`. Oczekiwany wynik: suma `-28`, maksimum `-3`, średnia `-7.00`.

## Odpowiedzi do ćwiczeń

1. Maksimum dla liczb ujemnych: inicjalizacja `maximum=0` zwróciłaby zły wynik. Zainicjuj z `values[0]`; pustą tablicę odrzuć przed pętlą.
2. Dzielenie całkowite: `total / count` ucina część ułamkową; rzutuj licznik przed dzieleniem, np. `(double)total / count`. Dla `[1,2]` oczekuj `1.5`.
3. Granica pętli: po inicjalizacji pierwszym elementem iteruj od indeksu 1 do `index < Length`.
4. Step Over pomija metodę, której nie analizujesz; Step Into wchodzi do `FindMaximum`; `values` można zobaczyć w ramce `RunScenario` i w ramce funkcji, która otrzymała tablicę.

Ustaw breakpoint w pętli maksimum. Obserwuj `i`, `values[i]`, `max`; w Watch dodaj `values.Length`. Step Out wraca z bieżącej funkcji.
