# Błędy wykonania

Uruchom standardowo: `dotnet run --project src/02-debug/02-bledy-wykonania/BledyWykonania.csproj` (średnia `4.00`). Repro-case błędnej liczby: dodaj `-- --demo-invalid`; `x` wywoła `FormatException`, zapisany bezpiecznie do stderr wraz ze stack trace.

1. Dzielenie przez zero: `Divide(10,0)` zgłasza czytelny `ArgumentException`; `10/2` daje 5. Rzutowanie przed dzieleniem zachowuje ułamki.
2. Odczyt: `TryReadNumber` używa `int.TryParse`, a średnia odrzuca niepoprawne wejście jasnym błędem.
3. Pusta lista: `CalculateAverage([])` zgłasza `ArgumentException` przed dzieleniem. `Debug.Assert` dokumentuje założenie o niepustym raporcie po walidacji.
4. Przykładowe issue: tytuł „CalculateAverage odrzuca ocenę x”; kroki: uruchom z `--demo-invalid`; aktualnie log `FormatException` dla x; oczekiwane: jasne odrzucenie tekstu; środowisko: .NET 8+, commit z `git rev-parse --short HEAD`.

Czytaj stack trace od typu wyjątku i wartości wejściowej do pierwszej ramki kodu projektu, a następnie do wywołującego. Nie umieszczaj tokenów ani prywatnych danych w logach.
