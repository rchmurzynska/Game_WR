﻿// See https://aka.ms/new-console-template for more information

Console.CursorVisible = false;

Dictionary<string, Point> directionsMap = new Dictionary<string, Point>();
directionsMap.Add("moveLeft", new Point(-1, 0));
directionsMap.Add("moveRight", new Point(1, 0));
directionsMap.Add("moveUp", new Point(0, -1));
directionsMap.Add("moveDown", new Point(0, 1));

Point startingPoint = new Point(18, 1);
Player hero = new Player("Star", "S");
hero.speed = 1;
hero.position = startingPoint;

List<Character> characters = new List<Character>();
characters.Add(hero);

NonPlayerCharacter npc = new NonPlayerCharacter("Enemy", "E");
npc.position = new Point(5, 5);

Level firstLevel = new Level();
firstLevel.Display();

foreach (Character element in characters)
{
    element.Display();
}

npc.Display();

while (true)
{
    Console.SetCursorPosition(12, 0);
    Console.Write(hero.speed);

    foreach (Character element in characters)
    {
        element.Display();
    }

    int charactersAmount = characters.Count;
    for (int i = 0; i < charactersAmount; i++)
    {
        Character element = characters[i];
        element.Display();

        string chosenAction = element.ChooseAction();
        if (!directionsMap.ContainsKey(chosenAction))
        {
            if (chosenAction == "clone")
            {
                PlayerClone clone = new PlayerClone(hero, "C");
                clone.position = startingPoint;
                characters.Add(clone);
            }

            continue;
        }

        Point direction = directionsMap[chosenAction];
        element.Move(direction, firstLevel);
    }
}

Console.WriteLine("Press Enter to continue...");
ConsoleKeyInfo keyInfo = Console.ReadKey(true);
while (keyInfo.Key != ConsoleKey.Enter)
{
    keyInfo = Console.ReadKey(true);
}
    

    
