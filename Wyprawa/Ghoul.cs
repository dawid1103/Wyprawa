﻿using System;
using System.Drawing;

namespace Wyprawa
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10) { }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                Direction playerDirection = FindPlayerDirection(game.playerLocation);
                if (random.Next(1, 3) != 1)
                    location = Move(playerDirection, game.Boundaries);

                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}
