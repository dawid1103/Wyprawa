using System;
using System.Drawing;

namespace Wyprawa
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name
        {
            get { return "Buława"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Top, 20, 6, random);
            DamageEnemy(Direction.Right, 20, 6, random);
            DamageEnemy(Direction.Down, 20, 6, random);
            DamageEnemy(Direction.Left, 20, 6, random);
        }
    }
}
