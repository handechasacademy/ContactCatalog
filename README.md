---Hur man kör----

Starta programmet

Öppna projektet.

Kör programmet, så kommer du att se instruktioner på skärmen.

--Vad du kan göra--

Lägg till nya kontakter med namn, e-post och taggar.

Uppdatera information eller taggar för befintliga kontakter.

Ta bort kontakter du inte behöver längre.

Sök kontakter efter namn eller filtrera efter taggar.

Lista alla kontakter i katalogen.

--Fel och meddelanden--

Om du försöker lägga till en kontakt med redan använd e-post eller ID, får du ett felmeddelande.

Om du söker efter något som inte finns, får du också ettmeddelande om att katalogen är tom.

Testerna

Projektet har inbyggda tester som ser till att allt fungerar som det ska.

Om du vill, kan du köra testerna för att dubbelkolla att alla funktioner fungerar korrekt.

-----
--Designval--

-Lagerstruktur-

Repository: Hanterar lagring och datavalidering (t.ex. inga dubbletter).

Service: Tar hand om användarinteraktion och felmeddelanden.

Models: Representerar kontakter med ID, namn, e-post och taggar.

Exceptions: Egna feltyper (ContactNotFoundException, DuplicateEmailException, InvalidInputException) för tydlighet.

-Felsäkerhet-

Repository kastar undantag vid fel (t.ex. duplicerad e-post).

Service fångar undantag och ger tydliga meddelanden till användaren.

-Loggning-

ILogger<ContactRepository> används för att logga händelser och fel.

-Tester-

xUnit för repository och validatorer.

Moq för service-lagret, vilket möjliggör isolerade tester.

-Principer-

Separation of concerns: varje lager har sitt ansvar.

Enkel att utöka: ny funktionalitet kan läggas till utan att bryta existerande kod.

Konsekvent felhantering och tydliga meddelanden överallt.
