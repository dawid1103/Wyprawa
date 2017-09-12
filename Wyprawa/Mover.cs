using System;
using System.Drawing;

namespace Wyprawa
{
    abstract class Mover
    {
        private const int moveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
                return false;
        }

        public bool Nearby(Point locationToCheck, Point targetLocation, int distance)
        {
            if (Math.Abs(targetLocation.X - locationToCheck.X) < distance && Math.Abs(targetLocation.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
                return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Top:
                    if (newLocation.Y - moveInterval >= boundaries.Top)
                        newLocation.Y -= moveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + moveInterval <= boundaries.Right)
                        newLocation.X += moveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + moveInterval <= boundaries.Bottom)
                        newLocation.Y += moveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - moveInterval >= boundaries.Left)
                        newLocation.X -= moveInterval;
                    break;
                default:
                    break;
            }
            return newLocation;
        }

        public Point Move(Direction direction, Point target, Rectangle boundaries)// na potrzeby DamageEnemy z Weapon
        {
            Point newLocation = target;
            switch (direction)
            {
                case Direction.Top:
                    if (newLocation.Y - moveInterval >= boundaries.Top)
                        newLocation.Y -= moveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + moveInterval <= boundaries.Right)
                        newLocation.X += moveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + moveInterval <= boundaries.Bottom)
                        newLocation.Y += moveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - moveInterval >= boundaries.Left)
                        newLocation.X -= moveInterval;
                    break;
                default:
                    break;
            }
            return newLocation;
        }
    }
}