# SharpHeroAPI
A C# .NET library for the SuperHero API. Access all your favourite characters!

# Sample Code
Before doing any programming you will need an api key. To get one visit https://superheroapi.com/index.html (all you need is a FaceBook account).

## Search for a character by name.
When searching by a name, the program will return a list of results.
The below example returns a list of characters when searching for "ironman".
```csharp
SuperHeroClient client = new SuperHeroClient(API_KEY);
List<Character> characters = client.SearchByName("ironman");
foreach (var character in characters)
{
   Console.WriteLine(character.name);
}
Console.ReadLine();
```

## Search for a character by ID.
If you want to only retrieve one character instead of a list of them, you can search for one with an ID. To see all character IDs go to https://superheroapi.com/ids.html.
The below example searches for the character "ironman".
```csharp
SuperHeroClient client = new SuperHeroClient(API_KEY);
Character character = client.SearchById(346);
Console.WriteLine(character.name);
Console.ReadLine();
```

# Character Information

## Biography Info
In order to get the basic character information, you need to access the "biography" list. The below code shows ironmans fullname.
```csharp
SuperHeroClient client = new SuperHeroClient(API_KEY);
Character character = client.SearchById(346);
Console.WriteLine(character.biography.fullname);
Console.ReadLine();
```
You can access other 'biography' info such as 'alteregos' or 'placeofbirth'.

## Appearance Info
To get the characters appearance, you need to acces the "appearance" list. The code below shows ironmans gender.
```csharp
SuperHeroClient client = new SuperHeroClient(API_KEY);
Character character = client.SearchById(346);
Console.WriteLine(character.appearance.gender);
Console.ReadLine();
```
Again, you can also access other 'appearance' info such as 'eyecolor' or 'haircolor'

## Connections Info
To get the characters connections with other groups/characters, you need to acces the "connections" list. The code below shows ironmans relatives.
```csharp
SuperHeroClient client = new SuperHeroClient(API_KEY);
Character character = client.SearchById(346);
Console.WriteLine(character.connections.relatives);
Console.ReadLine();
```
You can access a characters group (for example "The Avengers") by using 'groupaffiliation'.
