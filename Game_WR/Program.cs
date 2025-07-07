// See https://aka.ms/new-console-template for more information

Console.CursorVisible = false;

Dictionary<ConsoleKey, string> keyActionMap = new Dictionary<ConsoleKey, string>();
keyActionMap.Add(ConsoleKey.A, "moveLeft");
keyActionMap.Add(ConsoleKey.D, "moveRight"); 
keyActionMap.Add(ConsoleKey.W, "moveUp");
keyActionMap.Add(ConsoleKey.S, "moveDown");
keyActionMap.Add(ConsoleKey.Escape, "exit");
keyActionMap.Add(ConsoleKey.F, "attack");


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
Level FirstLevel = new Level (@"C:\Users\roksa\Desktop\Game_WR\Game_WR\Levels\FirstLevel.txt");

Level currentLevel = FirstLevel;
Player hero = new Player("Star", "S", startingPoint, currentLevel, keyActionMap);


