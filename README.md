# Wetterstation Observer Projekt

Dieses Projekt demonstriert die Verwendung des Observer-Entwurfsmusters zur Überwachung von Personen, die in einer Stadt leben, während diese täglich Wetterinformationen von einer Wetterstation empfangen. Die Implementierung erfolgt in C# und illustriert die Konzepte von Observers und Observables.

## Funktionsweise

Das Projekt besteht aus zwei Hauptkomponenten: Observers und Observable.

### Observers

Die Observers repräsentieren die Personen, die in der Stadt leben und täglich Wetterinformationen empfangen. Jeder Observer hat eine eindeutige Identität. Die Observers werden über Änderungen der Wetterdaten informiert und können entsprechend reagieren.

### Observable

Das Observable ist eine Klasse, die die Wetterstation darstellt. Die Wetterstation sammelt täglich Wetterdaten wie maximale, minimale und durchschnittliche Temperatur der Stadt. Wenn sich die Wetterdaten ändern, informiert die Wetterstation automatisch alle registrierten Observers darüber.

## Installation

Um das Projekt auszuführen, müssen Sie sicherstellen, dass Sie die erforderlichen Tools für die C#-Entwicklung auf Ihrem System installiert haben. Klonen Sie dann dieses Repository auf Ihren lokalen Computer.

```sh
git clone https://github.com/your_username/WeatherStation_Observer.git
