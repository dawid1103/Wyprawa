﻿using System;
using System.Drawing;

namespace Wyprawa
{
    abstract class Weapon : Mover
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public Weapon(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.playerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.enemies)
                {
                    if (Nearby(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
