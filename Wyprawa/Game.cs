using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wyprawa
{
    class Game
    {
        public List<Enemy> enemies;
        public Weapon WeaponInRoom;

        private Player player;
        public Point playerLocation { get { return player.Location; } }
        public int playerHitPoints { get { return player.HitPoints; } }
        public List<string> playerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70), boundaries); //Dawid = dodalem boundaries 
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in enemies)
                enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int healt, Random random)
        {
            player.IncreaseHealth(healt, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public int NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;

                case 3:
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(random)));
                    enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (!player.Weapons.Contains("Łuk"))
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    else
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 5:
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(random)));
                    enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(random)));
                    enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    if (!player.Weapons.Contains("Buława"))
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    else
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 8:
                    MessageBox.Show("koenic gry");
                    Application.Exit();
                    break;
            }
            return level;
        }
    }
}
