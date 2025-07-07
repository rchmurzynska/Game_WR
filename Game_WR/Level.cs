class Level
{
    string[] levelVisuals =
    {
        "###########################################",
        "#.........................................#",
        "#.........................................#",
        "#.........########........................#",
        "#.........................................#",
        "#.........................................#",
        "#........................########.........#",
        "#.........................................#",
        "######....................................#",
        "#.........................................#",
        "#.........................................#",
        "#....................................######",
        "#.........................................#",
        "#.........................................#",
        "#.........................................#",
        "#.........................................#",
        "#.........................................#",
        "#.........................................#",
        "#.........................................#",
        "#.........................................#",
        "###########################################"
    };

    List<List <Cell>> levelData;
    public Level()
        {
            levelData = new List<List<Cell>>();

            for (int y = 0; y < levelVisuals.Length; y++)
                {
                    List<Cell> row = new List<Cell>();
                    for (int x = 0; x < levelVisuals[y].Length; x++)
                        {
                            char cellVisuals = levelVisuals[y][x];
                            Cell cell = new Cell(cellVisuals);
                            row.Add(cell);
                        }
                            levelData.Add(row);
                }
        }

    public void Display()
        {
            foreach (List<Cell> row in levelData)
                {
                    foreach (Cell cell in row)
                        {
                        cell.Display();
                        }
                    Console.WriteLine();
                }
        }

    public char GetCellVisuals(int x, int y)
        {
            return levelVisuals[y][x];
        }

    public int GetWidth()
        {
            return levelVisuals[0].Length;
        }

    public int GetHeight()
        {
            return levelVisuals.Length;
        }

    public void SetCellVisuals(int x, int y, char newVisual)
    {
            if (y >= 0 && y < levelVisuals.Length && x >= 0 && x < levelVisuals[y].Length)
                {
                    char[] rowChars = levelVisuals[y].ToCharArray();
                    rowChars[x] = newVisual;
                    levelVisuals[y] = new string(rowChars);
                }
    }

}