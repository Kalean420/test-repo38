# test-repo38
repozytorium testowe - demonstracyjne
# nowy tekst
tu dopisałem nowy tekst

## Lab 01 — C#

Rozwiązania trzech zadań z laboratorium znajdują się w osobnych projektach konsolowych .NET 8. Każdy program sprawdza, czy wpisano poprawną, skończoną liczbę. Wpisuj liczby zgodnie z ustawieniami regionalnymi komputera (w Polsce separatorem dziesiętnym jest zwykle przecinek).

### Uruchamianie

W terminalu, w katalogu głównym repozytorium, uruchom wybrane polecenie:

```powershell
dotnet run --project Lab01/Task1/Task1.csproj
dotnet run --project Lab01/Task2/Task2.csproj
dotnet run --project Lab01/Task3/Task3.csproj
```

- **Zadanie 1:** program pobiera pięć liczb pojedynczo i natychmiast kończy działanie, jeśli kolejna nie jest ściśle większa.
- **Zadanie 2:** rozwiązuje `a*x+b=0`, w tym równanie tożsamościowe i sprzeczne.
- **Zadanie 3:** obsługuje `a=0` przez sprowadzenie do równania liniowego, a dla `a≠0` rozpatruje wszystkie przypadki wyróżnika.
- Rozgałęzienia są zapisane instrukcjami `if`/`else`, a operator warunkowy `?:` jest użyty przy wyborze wyniku.

Diagramy pełnej logiki zadań 2 i 3 są w formacie SVG w `Lab01/Diagrams/`.
