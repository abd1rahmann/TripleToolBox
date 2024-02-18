# Project1

## Beskrivning
Projekt1 är en C#-applikation som tillåter användare att utföra beräkningar på olika former, räkna med en miniräknare och spela Rock, Paper, Scissors.

## Funktioner
- **Beräkningar:**
  - Användare kan räkna ut omkrets och area för olika geometriska former.
  - Beräkningar sparas i en databas för framtida referens.
  - Det går att ändra på räkningarna.
  - Det går att göra Soft-Delete på samtliga beräkningar


- **Rock, Paper, Scissors-spel:**
  - Användaren kan spela Rock, Paper, Scissors mot datorn.
  - Spelet registrerar resultatet och visar statistik.

   - **Miniräknare:**
   - Användaren väljer ett räknesätt, matar in två tal och får resultat.
   - Räkningarna sparas i en databas.
   - Det går att ändra på räkningarna.
   - Det går att göra Soft-Delete på samtliga beräkningar


## Teknologier och mönster
- **ASP.NET Core och Entity Framework:**
  - Projekten använder ASP.NET Core för webbapplikationens backend.
  - Entity Framework används för att interagera med databasen.

- **MVC-mönster:**
  - Applikationen använder Model-View-Controller (MVC)-mönstret för att separera ansvarsområden och underlätta underhåll.

- **Dependency Injection (DI):**
  - DI används för att hantera och injicera beroenden i olika delar av applikationen, vilket gör koden mer testbar och underlättar lös koppling.

## Struktur
Projektet är strukturerat enligt följande:

- **Data:**
  - Innehåller dataklasser och DbContext för att hantera databasinteraktion.

- **Shapes:**
  - Innehåller klasser för att utföra beräkningar av olika geometriska former.

- **RockPaperScissors:**
  - Innehåller klasser för att implementera Rock, Paper, Scissors-spelet.
 
    - **Calcylator:**
  - Innehåller klasser för att utföra räkningar med olika räknesätt.


- **Controllers:**
  - MVC-controllers som hanterar användarinteraktion och routing.

- **Views:**
  - HTML-filer som representerar användargränssnittet.

## Installation och körning
1. Klona projektet från GitHub: `git clone https://github.com/din-anvandare/projekt1.git`
2. Öppna projektet i Visual Studio eller valfri IDE.
3. Konfigurera databasanslutningen i `appsettings.json`.
4. Kör migrationskommandon för att skapa och uppdatera databasen: `dotnet ef database update`.
5. Kör applikationen: `dotnet run`.

## Bidra
1. Forka projektet.
2. Skapa en gren för dina ändringar: `git checkout -b din-gren`.
3. Gör ändringarna och bekräfta dem: `git commit -m "Beskrivning av ändringar"`.
4. Pusha till din gren: `git push origin din-gren`.
5. Skapa en Pull Request.
