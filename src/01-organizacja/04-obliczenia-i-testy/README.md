# Obliczenia i testy

`PoleTrojkata` przyjmuje skończone, nieujemne wymiary i zwraca `podstawa * wysokosc / 2`. Program sprawdza `4,3 → 6`, `0,3 → 0`, wartość ujemną i nieskończoność.

Przypadki `CzyPierwsza`: 3 przechodzi bez dzielnika i daje true; 4 trafia na dzielnik 2 i daje false; 25 sprawdza dzielniki do pierwiastka i trafia na 5; -7 kończy się na warunku `n < 2`. Mutacja `sum / (count - 1)` jest wykrywana przez `[2,4,6] → 4` (mutacja daje 6), a lista jednoelementowa dzieliłaby przez zero.

Uruchom: `dotnet run --project src/01-organizacja/04-obliczenia-i-testy/Obliczenia.csproj`.
