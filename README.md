# LIquid-Rechner

Dieses kleine Konsolenprogramm berechnet die Anteile für das Mischen von E-Liquid.

## Benötigte Software

* [.NET SDK](https://dotnet.microsoft.com/) ab Version 6 oder Visual Studio 2019 (oder neuer) für Windows.

## Build

1. Repository klonen oder herunterladen.
2. In das Verzeichnis `Liquid-Rechner` wechseln.
3. Das Projekt mit dem .NET CLI oder Visual Studio builden.

Mit der .NET CLI:

```bash
dotnet build LIquid-Rechner.csproj
```

## Ausführen

Nach dem Build befindet sich das kompiliere Programm im Ordner `bin/Debug` oder `bin/Release`.
Das Programm kann durch Aufrufen der erzeugten `.exe` gestartet werden:

```bash
./bin/Debug/LIquid-Rechner.exe
```

Das Programm fragt nach der gewünschten Gesamtmenge des Liquids, dem Aromaanteil, der Ziel-Nikotinstärke und der Nikotinstärke der Shots. Anschließend werden die zu mischenden Mengen ausgegeben.
