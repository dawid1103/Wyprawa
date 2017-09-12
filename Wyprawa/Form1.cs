using System;
using System.Drawing;
using System.Windows.Forms;

namespace Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            picPlayer.Location = game.playerLocation;
            playerHitPoints.Text = game.playerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.enemies)
            {
                if (enemy is Bat)
                {
                    picBat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    picGhost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    picGhoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            picBat.Visible = showBat;
            picGhost.Visible = showGhost;
            picGhoul.Visible = showGhoul;

            picSword.Visible = false;
            picMace.Visible = false;
            picBow.Visible = false;
            picBluePotion.Visible = false;
            picRedPotion.Visible = false;

            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = picSword;
                    break;
                case "Łuk":
                    weaponControl = picBow;
                    break;
                case "Buława":
                    weaponControl = picMace;
                    break;
                case "Czerwona mikstura":
                    weaponControl = picRedPotion;
                    break;
                case "Niebieska mikstura":
                    weaponControl = picBluePotion;
                    break;
            }

            weaponControl.Visible = true;

            inventorySword.Visible = game.CheckPlayerInventory("Miecz");
            inventoryBow.Visible = game.CheckPlayerInventory("Łuk");
            inventoryMace.Visible = game.CheckPlayerInventory("Buława");
            inventoryRedPotion.Visible = game.CheckPlayerInventory("Czerwona mikstura");
            inventoryBluePotion.Visible = game.CheckPlayerInventory("Niebieska mikstura");

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;


            if (game.playerHitPoints <= 0)
            {
                MessageBox.Show("zostałeś zabity");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
                if (game.NewLevel(random) == 8)
                {
                    Application.Exit();
                }
                else
                    UpdateCharacters();

            }
        }

        private void moveTop_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "moveTop":
                    game.Move(Direction.Top, random);
                    UpdateCharacters();
                    break;
                case "moveRight":
                    game.Move(Direction.Right, random);
                    UpdateCharacters();
                    break;
                case "moveDown":
                    game.Move(Direction.Down, random);
                    UpdateCharacters();
                    break;
                case "moveLeft":
                    game.Move(Direction.Left, random);
                    UpdateCharacters();
                    break;
            }
        }

        private void attackTop_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            PotionInHand(false);
            switch (button.Name)
            {
                case "attackTop":
                    game.Attack(Direction.Top, random);
                    UpdateCharacters();
                    break;
                case "attackRight":
                    game.Attack(Direction.Right, random);
                    UpdateCharacters();
                    break;
                case "attackDown":
                    game.Attack(Direction.Down, random);
                    UpdateCharacters();
                    break;
                case "attackLeft":
                    game.Attack(Direction.Left, random);
                    UpdateCharacters();
                    break;
                case "drinkPotion":
                    game.Attack(Direction.Left, random);
                    PotionInHand(false);
                    UpdateCharacters();
                    break;
            }
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
            PotionInHand(false);

            PictureBox pictureBox = sender as PictureBox;
            switch (pictureBox.Name)
            {
                case "inventorySword":
                    if (game.CheckPlayerInventory("Miecz"))
                    {
                        game.Equip("Miecz");
                        pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case "inventoryBow":
                    if (game.CheckPlayerInventory("Łuk"))
                    {
                        game.Equip("Łuk");
                        pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case "inventoryMace":
                    if (game.CheckPlayerInventory("Buława"))
                    {
                        game.Equip("Buława");
                        pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;
                case "inventoryRedPotion":
                    if (game.CheckPlayerInventory("Czerwona mikstura"))
                    {
                        game.Equip("Czerwona mikstura");
                        pictureBox.BorderStyle = BorderStyle.Fixed3D;
                        PotionInHand(true);
                    }
                    break;
                case "inventoryBluePotion":
                    if (game.CheckPlayerInventory("Niebieska mikstura"))
                    {
                        game.Equip("Niebieska mikstura");
                        pictureBox.BorderStyle = BorderStyle.Fixed3D;
                        PotionInHand(true);
                    }
                    break;
            }
        }

        private void PotionInHand(bool isInHand)
        {
            if (isInHand)
            {
                attackDown.Visible = false;
                attackRight.Visible = false;
                attackLeft.Visible = false;
                attackTop.Visible = false;
                drinkPotion.Visible = true;
            }
            else
            {
                attackDown.Visible = true;
                attackRight.Visible = true;
                attackLeft.Visible = true;
                attackTop.Visible = true;
                drinkPotion.Visible = false;
            }

        }
    }
}
