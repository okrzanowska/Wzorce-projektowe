# Wzorce Projektowe - Ćwiczenia Laboratoryjne

Repozytorium zawiera projekty realizowane w ramach ćwiczeń laboratoryjnych z przedmiotu **Wzorce projektowe**. Każdy projekt ilustruje różne aspekty programowania obiektowego i wzorców projektowych w języku C#.

## Spis treści

- [Struktura Repozytorium](#struktura-repozytorium)
- [Wymagania](#wymagania)
- [Technologie i narzędzia](#technologie-i-narzędzia)
- [Jak uruchomić?](#jak-uruchomić)
- [Cele Edukacyjne](#cele-edukacyjne)
- [Zadania](#zadania)
  - [Zadanie 1 - Figury Geometryczne](#zadanie-1-figury-geometryczne)
  - [Zadanie 2 - Zarządzanie Pojazdami](#zadanie-2-zarządzanie-pojazdami)
  - [Zadanie 3 - System HR](#zadanie-3-system-hr)
  - [Zadanie 4 - System Bankowy](#zadanie-4-system-bankowy)
  - [Zadanie 5 - Diagram UML](#zadanie-5-diagram-uml)
- [Wzorce projektowe zaimplementowane w projektach](#wzorce-projektowe-zaimplementowane-w-projektach)
- [Autorzy](#autorzy)
- [Licencja](#licencja)

## Struktura Repozytorium

- **Zadanie_01/**
  Projekt ilustrujący zastosowanie abstrakcji, dziedziczenia i polimorfizmu w kontekście figur geometrycznych.
  - `Shape.cs`: Klasa abstrakcyjna reprezentująca ogólną figurę geometryczną.
  - `Ellipse.cs`: Klasa pochodna reprezentująca elipsę.
  - `Circle.cs`: Klasa pochodna reprezentująca okrąg.
  - `Program.cs`: Główna logika programu.
  - `Zadanie_01.csproj`: Plik projektu .NET.

- **Zadanie_02/**
  Projekt ilustrujący zastosowanie enkapsulacji oraz getterów i setterów w zarządzaniu pojazdami.
  - `Vehicles.cs`: Klasa bazowa reprezentująca pojazd.
  - `Cars.cs`: Klasa pochodna reprezentująca samochód.
  - `Program.cs`: Główna logika programu.
  - `Zadanie_02.csproj`: Plik projektu .NET.

- **Zadanie_03/**
  Projekt ilustrujący zastosowanie polimorfizmu, agregacji i list w systemie zarządzania zasobami ludzkimi.
  - `Employee.cs`: Klasa abstrakcyjna reprezentująca pracownika.
  - `Manager.cs`: Klasa pochodna reprezentująca menedżera.
  - `Developer.cs`: Klasa pochodna reprezentująca programistę.
  - `HR_Specialist.cs`: Klasa pochodna reprezentująca specjalistę HR.
  - `Designer.cs`: Klasa pochodna reprezentująca projektanta.
  - `HRSystem.cs`: Klasa zarządzająca pracownikami.
  - `Program.cs`: Główna logika programu.
  - `Zadanie_03.csproj`: Plik projektu .NET.

- **Zadanie_04/**
  Projekt ilustrujący zastosowanie enkapsulacji, walidacji i obsługi wyjątków w systemie bankowym.
  - `BankAccount.cs`: Klasa reprezentująca konto bankowe.
  - `Program.cs`: Główna logika programu.
  - `Zadanie_04.csproj`: Plik projektu .NET.

- **Zadanie_05/**
  Projekt ilustrujący projektowanie architektury systemu za pomocą diagramów UML oraz zastosowanie wzorców projektowych.
  - `DIAGRAM_PLANTUML.puml`: Diagram w formacie PlantUML.
  - `PROPOZYCJA_KLAS.md`: Propozycja klas w systemie.
  - `OPIS_RELACJI.md`: Opis relacji UML.
  - `Zadanie_05.csproj`: Plik projektu .NET.

## Wymagania

- **.NET SDK 8.0**
  Projekty są zbudowane w oparciu o platformę .NET 8.0. Upewnij się, że masz zainstalowaną odpowiednią wersję SDK.

## Technologie i narzędzia

| Technologia | Zastosowanie |
|-------------|--------------|
| **C#** | Główny język programowania wszystkich projektów |
| **.NET 8.0** | Platforma programistyczna |
| **Visual Studio 2022** | IDE |
| **PlantUML** | Generowanie diagramów UML |
| **Git** | Kontrola wersji |

## Jak uruchomić?

Sklonuj repozytorium:

```
git clone https://github.com/okrzanowska/Wzorce-projektowe.git
cd Wzorce-projektowe
```

Przejdź do folderu projektu:

- Aby uruchomić projekt **Zadanie_01**, przejdź do folderu:
  ```
  cd Zadanie_01
  ```
- Aby uruchomić projekt **Zadanie_02**, przejdź do folderu:
  ```
  cd Zadanie_02
  ```
- Aby uruchomić projekt **Zadanie_03**, przejdź do folderu:
  ```
  cd Zadanie_03
  ```
- Aby uruchomić projekt **Zadanie_04**, przejdź do folderu:
  ```
  cd Zadanie_04
  ```
- Aby uruchomić projekt **Zadanie_05**, przejdź do folderu:
  ```
  cd Zadanie_05
  ```

Zbuduj projekt za pomocą polecenia `dotnet build`:

```
dotnet build
```

Uruchom projekt za pomocą polecenia `dotnet run`:

```
dotnet run
```

Aby wrócić do głównego folderu repozytorium, użyj:

```
cd ..
```

## Cele Edukacyjne

Głównym celem repozytorium jest praktyczna nauka koncepcji programowania obiektowego w C# oraz wzorców projektowych. W szczególności:

### 1. Koncepty Programowania Obiektowego

- **Abstrakcja**: Ukrywanie szczegółów implementacji i eksponowanie tylko istotnych interfejsów  
  - Implementacja w: Zadanie_01 (Shape - klasa abstrakcyjna), Zadanie_03 (Employee)

- **Dziedziczenie (Inheritance)**: Tworzenie hierarchii klas oraz ponowne wykorzystanie kodu  
  - Implementacja w: Zadanie_01 (Ellipse, Circle dziedziczą po Shape), Zadanie_02 (Cars dziedziczy po Vehicles), Zadanie_03 (Manager, Developer, HR_Specialist, Designer)

- **Enkapsulacja (Encapsulation)**: Ochrona danych poprzez pola prywatne i publiczne metody dostępu  
  - Implementacja w: Zadanie_02 (pola prywatne + publiczne metody), Zadanie_04 (BankAccount z pełną enkapsulacją)

- **Polimorfizm (Polymorphism)**: Możliwość używania obiektów różnych typów poprzez wspólny interfejs  
  - Implementacja w: Zadanie_01 (przesłanianie metod), Zadanie_03 (różne typy pracowników), Zadanie_05 (relacje UML)

### 2. UML i Architektura

- Projektowanie systemów za pomocą diagramów klas UML
- Zrozumienie relacji między obiektami (asocjacja, agregacja, kompozycja, dziedziczenie)
- Design patterns i ich zastosowanie praktyczne

## Zadania

### Zadanie 1: Elipsa i koło

Napisz program w języku C#, który zgodnie z zasadami programowania obiektowego (OOP) umożliwia obliczenie pola i obwodu elipsy oraz koła.

Program powinien zawierać trzy klasy:
- Shape - klasa abstrakcyjna, określająca wspólny interfejs dla figur geometrycznych. Zawiera metody: void ReadData() wczytuje dane z klawiatury, void ProcessData() wykonuje obliczenia, void ShowResults() wyświetla wyniki,
- Ellipse - klasa pochodna reprezentująca elipsę o półosiach a i b. Zawiera metody: ReadData() wczytuje półosie a i b z klawiatury, ProcessData() oblicza pole i przybliżony obwód, ShowResults() wyświetla półosie oraz wyniki (z dokładnością do dwóch miejsc po przecinku),
- Circle - klasa pochodna reprezentująca koło, które jest szczególnym przypadkiem elipsy (stąd dziedzicząca po Ellipse). Metody: ReadData() wczytuje promień z klawiatury, ProcessData() korzysta z implementacji klasy Ellipse, ShowResults() wyświetla dane dla koła: promień, pole i obwód.

Program główny wyświetla w terminalu menu kontekstowe, z którego użytkownik wybiera opcję przeprowadzenia obliczeń dla elipsy lub koła, następnie podaje potrzebne wartości i ostatecznie może wyświetlić wyniki.
Każda klasa powinna znajdować się w miarę możliwości w jednym pliku, a program główny (Main) w klasie Program. Program ma być napisany w sposób rozszerzalny i czytelny, a także zabezpieczać przed podstawowymi błędami (np. wartości ≤ 0).

### Zadanie 2: Samochody

Proszę napisać program zgodnie z zasadami paradygmatu obiektowego (OOP).
Utwórz klasę Vehicles, która zawiera następujące pola: name, manufacturer, id, mileage, years oraz dwie metody: read() i show(). Pierwsza z metod umożliwia wprowadzanie danych, natomiast druga wyświetla je w terminalu.
Niech program zawiera proces dziedziczenia — klasa Cars dziedziczy właściwości po klasie bazowej Vehicles i zawiera dwa dodatkowe pola: engine i color oraz dwie dodatkowe metody: read1() i show1().

### Zadanie 3: Dział HR

Proszę zaimplementować uproszczony system zarządzania działem HR w firmie wykorzystujący polimorfizm. Należy stworzyć klasę bazową Employee oraz kilka klas pochodnych reprezentujących różne typy wakatów (co najmniej trzy). Następnie należy napisać program, który będzie przechowywał listę pracowników i wywoływał na nich polimorficzne metody.

### Zadanie 4: Konto bankowe

Proszę stworzyć klasę BankAccount, która będzie reprezentować konto bankowe. Klasa powinna posiadać następujące właściwości:
- Numer konta (typu string)
- Saldo (typu decimal)

Wszystkie właściwości powinny być prywatne i dostępne tylko poprzez metody publiczne. Klasa powinna zawierać metody do:
- Pobierania numeru konta
- Pobierania bieżącego salda
- Dokonywania wpłat na konto
- Dokonywania wypłat z konta (jeśli saldo jest wystarczające)
- Przewalutowania (PLN, EUR i USD)

### Zadanie 5: Ruch lotniczy

Proszę zaprojektować w postaci diagramu klas UML przykładowy system do zarządzania flotą samolotów, który śledzi ruch samolotów pasażerskich (samoloty wylatujące w podróż i wracające z niej) oraz kontroluje trasy (tzn. lotniska transferowe). System powinien zawierać kilka klas bazowych oraz klasy pochodne. Główne wymagania systemu:

- Samoloty: śledzenie lotów, startów i lądowań,
- Trasy lotnicze: kontrola lotnisk i kolejności przelotów (FlightRoute),
- Klasy bazowe i pochodne: np. Aircraft -> PassengerAircraft, CargoAircraft,
- Lotniska: Airport i ich powiązanie z trasami,
- Rejestracja lotów: Flight.
- Rozwiązanie powinno zawierać rozpisaną propozycję klas bazowych i pochodnych, opis relacji UML oraz rozrysowany diagram klas UML.

## Autorzy

Projekty zostały stworzone w ramach zajęć laboratoryjnych z przedmiotu **Wzorce projetkowe** w roku akademickim 2024/2025.

- **Oliwia Krzanowska**: Autor repozytorium i realizator zadań.

## Licencja

Repozytorium jest przeznaczone wyłącznie do celów edukacyjnych.
