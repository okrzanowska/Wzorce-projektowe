# Propozycja klas - system zarządzania flotą samolotów

## Klasy bazowe i pochodne

### Aircraft (abstrakcyjna)
- **Pola:**
  - `registrationNumber: String` - numer rejestracyjny samolotu
  - `manufacturer: String` - producent
  - `model: String` - model
  - `capacity: int` - pojemność
  - `maxSpeed: double` - maksymalna prędkość
  - `currentAirport: Airport` - aktualne lotnisko
  - `status: FlightStatus` - status operacyjny
- **Metody:**
  - `GetInfo(): String` - zwraca informacje o samolocie
  - `TakeOff(Airport): void` - inicjuje start
  - `Land(Airport): void` - inicjuje lądowanie

### PassengerAircraft (dziedziczy z Aircraft)
- **Dodatkowe pola:**
  - `numberOfPassengers: int` - liczba pasażerów
  - `economySeats: int` - miejsca ekonomiczne
  - `businessSeats: int` - miejsca biznesowe
- **Dodatkowe metody:**
  - `BoardPassengers(int): void` - przyjmuje pasażerów
  - `GetAvailableSeats(): int` - zwraca liczbę wolnych miejsc

### CargoAircraft (dziedziczy z Aircraft)
- **Dodatkowe pola:**
  - `cargoCapacityInTons: double` - maksymalna pojemność ładunku
  - `currentCargoWeightInTons: double` - bieżąca masa ładunku
- **Dodatkowe metody:**
  - `LoadCargo(double): void` - załadunek
  - `UnloadCargo(double): void` - rozładunek

---

## Klasy wspierające

### Airport
- **Pola:**
  - `code: String` - kod IATA
  - `name: String` - nazwa lotniska
  - `country: String` - kraj
  - `totalGates: int` - liczba bramek
  - `activeFlights: List<Flight>` - aktywne loty
- **Metody:**
  - `RegisterFlight(Flight): boolean` - rejestracja lotu
  - `DeregisterFlight(Flight): boolean` - usunięcie lotu

### FlightRoute
- **Pola:**
  - `routeId: String` - identyfikator trasy
  - `departureAirport: Airport` - lotnisko wylotu
  - `arrivalAirport: Airport` - lotnisko przylotu
  - `distance: double` - odległość
  - `estimatedFlightDuration: TimeSpan` - czas lotu

### CrewMember
- **Pola:**
  - `crewId: String` - identyfikator
  - `name: String` - imię i nazwisko
  - `role: CrewRole` - rola w załodze

### Flight
- **Pola:**
  - `flightNumber: String` - numer lotu
  - `aircraft: Aircraft` - przypisany samolot
  - `route: FlightRoute` - trasa lotu
  - `crew: List<CrewMember>` - załoga

### FleetManager
- **Pola:**
  - `fleetName: String` - nazwa floty
  - `aircraft: List<Aircraft>` - lista samolotów
  - `airports: List<Airport>` - lista lotnisk
  - `flights: List<Flight>` - lista lotów
  - `routes: List<FlightRoute>` - lista tras
- **Metody:**
  - `AddAircraft(Aircraft): void` - dodanie samolotu
  - `ScheduleFlight(Flight): void` - zaplanowanie lotu
