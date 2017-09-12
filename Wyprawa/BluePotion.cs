using System;
using System.Drawing;

namespace Wyprawa
{
    class BluePotion : Weapon, IPotion
    {
        private bool used = false;
        public BluePotion(Game game, Point location) : base(game, location) { }

        public bool Used
        {
            get { return used; }
        }

        public override string Name
        {
            get { return "Niebieska mikstura"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;
        }
    }
}