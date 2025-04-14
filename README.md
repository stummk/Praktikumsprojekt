# Praktikumsprojekt
 Ein Template und Ablaufplan für ein 7-tägiges Praktikum im Bereich Softwareentwicklung mit Techstack c#.net, WebAPI, Blazor, SQLite. Als Projekt soll in diesem Zeutraum eine TODO-Webapp entwickelt werden. Bei der Entwiclung sollen verschiedene Technologien kennengelernt und erprobt wwerden.

 # Gesamtprojekt: "Todo-Manager"

Das Ziel ist, eine einfache To-Do-Liste zu entwickeln:

- **Backend:** Eine .NET Core Web API, die CRUD-Operationen (Create, Read, Update, Delete) zu To-Do-Items ermöglicht, und eine SQL-Datenbank als Speicher verwendet.

- **Frontend:** Eine Blazor-Anwendung, die über eine ansprechende Benutzeroberfläche mit der API kommuniziert.

Dieses Projekt ist überschaubar, erweitert aber schrittweise das Verständnis für die einzelnen Technologien.

---

### Tag 1 – Einführung & Setup
#### Was du heute machst:
- Du installierst alles, was du brauchst.
- Du erstellt ein erstes Consolen-Projekt
- Du holst dir das TODO-STarter-Projekt von Github und öffnest es in Visual Studio
  
#### Schritt für Schritt:
1. Installiere diese Programme:
   - [Visual Studio Community](https://visualstudio.microsoft.com/de/downloads/)
   - [Github Desktop](https://github.com/apps/desktop)
  
2. Downloade das TODO-Starterprojekt
   - Download oder Klone das [TOOD-Starter-Projekt](https://github.com/stummk/todo-starter) aus Github.
   - Es enthält 3 Projekte, das Frontend, Backend und Shared
3. Öffne die Solution und Erstelle ein Hello-World-Consolen Projekt.
   - Erste Variablen schreiben und auf Konsole ausgeben
   - Eingaben vom Nutzer auf der Konsole einlesen und bearbeiten und Ergebnis ausgeben.

#### Hilfe:
   - [Get started Visual Studio](https://learn.microsoft.com/en-us/visualstudio/ide/quickstart-ide-orientation?view=vs-2022)
   - [Get started C#](https://learn.microsoft.com/de-de/training/paths/get-started-c-sharp-part-1/)

---

### Tag 2 – Grundlagen der Programmierung in C#
#### Ziele:
- Verständnis grundlegender Programmierkonzepte in C#
- Erste einfache Programmierübungen
#### Schritte:
1. Grundlagen lernen:
    - Variablen, Datentypen, Schleifen, Bedingungen und Methoden.

    - Erstelle kleine Konsolenprogramme, die z. B. einfache Eingaben verarbeiten (z. B. Addition, Abfrage von Nutzereingaben).

2. OOP-Konzepte in C#:

    - Einführung in Klassen, Objekte, Vererbung und Interfaces.

   - Erweiter die `TodoItem`-Klasse im Shared Projekt, damit sie eine numerische Id hat, einen Titel und einen Wert, der anzeigt, ob das Element bereits abgeschlossen ist.

---

### Tag 3 – Einführung in Blazor
#### Ziele:
- Verständnis des Konzepts von Blazor
- Erstellen einer einfachen Blazor WebAssembly-Anwendung
#### Schritte:
- Blazor Anwendung erweitern, damit eine Liste von Todo's angezeigt wird.
- Buttons zum hinzufügen, löschen
- Checkboxen zum abschließen
- Ansicht zum bearbeiten
- CSS-Styling

---

### Tag 4 – Einführung in .NET Core Web API
#### Ziele:
- Grundverständnis für den Aufbau einer Web API mit .NET Core
- Erste einfache Endpunkte implementieren
#### Schritte:
- Endpunkt zum Anzeigen einer Todo-Liste erweitern
- Endpunkt zum Anzeigen eines einzelnen Elementes erweitern
- Endpunkte zum Hinzufügen, Bearbeiten, Löschen hinzufügen

---

### Tag 5 – Integration: API & Blazor Frontend
#### Ziele:
- Verknüpfen der Blazor-Oberfläche mit der Web API
- CRUD-Funktionalität am Beispiel der To-Do-Liste
#### Schritte:
- Erarbeite, wie man HTTP-Anfragen (GET, POST, PUT, DELETE) aus Blazor heraus durchführt.
- Verwende die HttpClient-Klasse in Blazor, um mit deiner Web API zu kommunizieren.

---

### Tag 6 – Datenbank und Persistenz mit SQL
#### Ziele:
- Du speicherst Aufgaben dauerhaft in einer SQLite-Datenbank.
- Benutzung von ENtity-Framework und Linq um Daten in die Datenbank zu speichern oder zu bearbeiten
#### Schritte:
- Führe eine Datenbank Migration aus, damit die Tabellen in der Datenbank angelegt werden. Dazu in der Package-Manager-Console folgende Befehle ausführen:

```shell
dotnet ef migrations add Init
dotnet ef database update
```

- Erweitere die Endpunkte der API im TodoController, damit sie mit der Datenbank kommunizieren. Beispiel:
```csharp
...

[HttpGet]
public async Task<ActionResult<IEnumerable<TodoItem>>> Get() {
   return await _context.ToDos.ToListAsync();
}
...
```

---

### Tag 7 – Abschlusstest, Verfeinerung & Dokumentation
#### Ziele:
- Du probierst alles aus: Aufgaben erstellen, anzeigen, löschen (je nach Fortschritt).
- Du schreibst eine kurze Beschreibung deines Projekts.
- Du machst eine kurze Präsentation des Projektes
- Feedback
- Ergebnis sichern
