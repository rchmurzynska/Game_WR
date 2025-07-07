using System.Runtime;

abstract class Character
{
    public string name;
    public Point position;
    public int speed = 1;
    public string avatar;

    public Character(string name, string avatar)
    {
        this.name = name;
        this.avatar = avatar;
    }

    public void Move(Point direction, Level level)
    {
        Point target = position;

        int signX = Math.Sign(direction.x);
        for (int x = 1; x <= Math.Abs(direction.x * speed); x++)
        {
            int coordinateToTest = position.x + x * signX;
            if (level.GetCellVisuals(coordinateToTest, target.y) == '#')
            {
                break;
            }

            target.x = coordinateToTest;
        }

        int signY = Math.Sign(direction.y);
        for (int y = 1; y <= Math.Abs(direction.y * speed); y++)
        {
            int coordinateToTest = position.y + y * signY;
            if (level.GetCellVisuals(target.x, coordinateToTest) == '#')
            {
                break;
            }

            target.y = coordinateToTest;
        }
    }
}