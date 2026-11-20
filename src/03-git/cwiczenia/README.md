# Odpowiedzi do ćwiczeń Git

## Podstawy

Historia: utwórz `git-01`, `git init -b main`, dodaj README. Przed commitem sprawdź `git status`, `git add`, `git diff --staged`; po drugiej zmianie obejrzyj `git diff`. Dwa commity powinny opisywać osobne logiczne zmiany. `git diff` pokazuje nieprzygotowane zmiany; `git diff --staged` te czekające na commit. `.gitignore` powinien ignorować `.env`, `.vscode/`, `bin/` i `obj/`; dodaj tylko pliki potrzebne do projektu. Dobre commity są krótkie i konkretne, np. `docs: add setup instructions`.

## Remote i review

Dodaj `origin`, sprawdź `git remote -v`, wykonaj `git push -u origin main`. `fetch` pobiera dane bez integracji, `pull` pobiera i integruje, `push` publikuje commity. Stan sprawdź przez `git status -sb` i `git log --oneline --graph --all`. Zły adres popraw `git remote set-url origin <URL>`. W parze reviewer wskazuje konkretną obserwację, ryzyko i sugestię; autor odpowiada nowym commitem.

## Gałęzie i konflikt

W `feature/konflikt` zapisz w `konflikt.txt` `Wersja z gałęzi feature`; na `main` zmień tę samą linię na `Wersja z main`; wróć na feature i `git merge main`. Rozwiąż do `Wersja z main oraz wersja z gałęzi feature`, usuń znaczniki, sprawdź diff/status/log i zatwierdź. Merge zachowuje rozgałęzienie; rebase przenosi commity i zmienia ich identyfikatory. Anulowanie: `git merge --abort`, `git rebase --abort`.

## PR, Issues i Projects

PR twórz z gałęzi funkcjonalnej do `main`; opisuj cel, zakres i sprawdzenie. Po review poprawiaj nowym commitem. Issue powinno mieć konkretne kryteria akceptacji. Projects: przenieś kartę `Ready → In progress → Done`, powiąż PR i zamknij issue po scaleniu. Rzeczywisty review wymaga drugiej osoby.

## Nietypowe sytuacje

- Błędny udostępniony commit: popraw stan i użyj `git revert <sha>`.
- Sekret: najpierw unieważnij token u dostawcy, potem usuń go z plików/historii, uzgodnij synchronizację i sprawdź logi. Nigdy nie publikuj tokenu.
- Nieopublikowana historia: kopia gałęzi, `git rebase -i HEAD~3`; `squash`, `edit`, `drop` według planu.
- Odzyskanie: sprawdź `git reflog`, utwórz `git switch -c recovery <sha>`.
- Bisect: `git bisect start`, oznacz `bad` i `good`, sprawdzaj wersje, na końcu `git bisect reset`.
- Cherry-pick: `git cherry-pick <sha>`; po konflikcie popraw plik, `git add`, `git cherry-pick --continue` albo `--abort`.

Po każdej operacji obejrzyj status, diff, historię i działanie projektu. `--force-with-lease` używaj tylko po uzgodnieniu ze współpracownikami.
