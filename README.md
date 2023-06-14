# MSTest Projekt

## Beskrivning

Detta projekt innehåller en serie tester som utförs med MSTest ramverket. Testerna validerar funktionaliteten av vår applikation "TeamMangoBank". Testerna fokuserar på användarskapande, administratörsgodkännande samt sparkontofunktioner.

För att göra testerna mer hanterbara och lättlästa har koden som ska testas extraherats och placerats i en egen klass som heter `MethodToTest`. Testerna själva ligger i `MS-Test` klassen.

## Tester

Här är en beskrivning av de tester som ingår i projektet:

1. `CreateUser_RunBankShouldReturn_5_Users`: Detta test kontrollerar att metoden `RunBank` skapar fem användare. Om mindre än fem användare skapas, kommer testet att misslyckas.

2. `LoginAdmin_ShouldReturnTrue`: Detta test verifierar att en användare som loggar in verkligen är en administratör. Om användaren inte är en administratör, kommer testet att misslyckas.

3. `OpenSavingsAccount_ShouldReturn_CorrectAccountNameAndAmount`: Detta test kontrollerar att när en användare öppnar ett sparkonto, är den insatta summan korrekt. Om summan inte stämmer överens med det insatta beloppet, kommer testet att misslyckas.

## Installation och användning

För att köra testerna, följ stegen nedan:

```bash
# Klona repository
git clone https://github.com/BKKinvader/MS-Test.git

# Kör testerna
dotnet test
