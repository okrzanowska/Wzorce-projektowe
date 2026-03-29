# Opis relacji UML

## Relacje między klasami

### Dziedziczenie
- `PassengerAircraft` i `CargoAircraft` dziedziczą z `Aircraft`.

### Asocjacje
- `Flight`:
  - posiada 1 `Aircraft`
  - korzysta z 1 `FlightRoute`
  - ma przypisane lotnisko wylotu i przylotu (`Airport`)
  - ma załogę (`CrewMember`)

### Agregacja
- `FleetManager` zarządza kolekcjami:
  - `Aircraft`
  - `Airport`
  - `Flight`
  - `FlightRoute`

### Wiele-do-wielu
- `Flight` ↔ `CrewMember`: jeden lot może mieć wielu członków załogi, a jeden członek załogi może uczestniczyć w wielu lotach.

---

## Diagram relacji

Relacje między klasami zostały przedstawione w diagramie UML w pliku `DIAGRAM_PLANTUML.puml`. Diagram zawiera:
- Dziedziczenie (`Aircraft` → `PassengerAircraft`, `CargoAircraft`)
- Asocjacje (`Flight` ↔ `Aircraft`, `FlightRoute`, `Airport`, `CrewMember`)
- Agregacje (`FleetManager` zarządza kolekcjami obiektów)
- Enumy (`FlightStatus`, `CrewRole`) używane w odpowiednich klasach.
