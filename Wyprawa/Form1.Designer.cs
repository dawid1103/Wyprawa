namespace Wyprawa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.moveTop = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.attackTop = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picBat = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picGhoul = new System.Windows.Forms.PictureBox();
            this.picBluePotion = new System.Windows.Forms.PictureBox();
            this.picRedPotion = new System.Windows.Forms.PictureBox();
            this.picMace = new System.Windows.Forms.PictureBox();
            this.picBow = new System.Windows.Forms.PictureBox();
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.drinkPotion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruch";
            // 
            // moveTop
            // 
            this.moveTop.Location = new System.Drawing.Point(673, 46);
            this.moveTop.Name = "moveTop";
            this.moveTop.Size = new System.Drawing.Size(75, 23);
            this.moveTop.TabIndex = 1;
            this.moveTop.Text = "Góra";
            this.moveTop.UseVisualStyleBackColor = true;
            this.moveTop.Click += new System.EventHandler(this.moveTop_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(625, 75);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(75, 23);
            this.moveLeft.TabIndex = 2;
            this.moveLeft.Text = "Lewo";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveTop_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(719, 75);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(75, 23);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = "Prawo";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveTop_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(673, 104);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(75, 23);
            this.moveDown.TabIndex = 4;
            this.moveDown.Text = "Dół";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveTop_Click);
            // 
            // attackTop
            // 
            this.attackTop.Location = new System.Drawing.Point(673, 180);
            this.attackTop.Name = "attackTop";
            this.attackTop.Size = new System.Drawing.Size(75, 23);
            this.attackTop.TabIndex = 5;
            this.attackTop.Text = "Góra";
            this.attackTop.UseVisualStyleBackColor = true;
            this.attackTop.Click += new System.EventHandler(this.attackTop_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(625, 209);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(75, 23);
            this.attackLeft.TabIndex = 6;
            this.attackLeft.Text = "Lewo";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackTop_Click);
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(719, 209);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(75, 23);
            this.attackRight.TabIndex = 7;
            this.attackRight.Text = "Prawo";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackTop_Click);
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(673, 238);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(75, 23);
            this.attackDown.TabIndex = 8;
            this.attackDown.Text = "Dół";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackTop_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(620, 294);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 94);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(90, 71);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(90, 50);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(90, 25);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(90, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gracz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nietoperz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Upiór";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Atak";
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Wyprawa.Properties.Resources.wizard;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(80, 60);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 30);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 11;
            this.picPlayer.TabStop = false;
            // 
            // picSword
            // 
            this.picSword.BackColor = System.Drawing.Color.Transparent;
            this.picSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSword.Image = ((System.Drawing.Image)(resources.GetObject("picSword.Image")));
            this.picSword.Location = new System.Drawing.Point(116, 60);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(30, 30);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 12;
            this.picSword.TabStop = false;
            this.picSword.Visible = false;
            // 
            // picBat
            // 
            this.picBat.BackColor = System.Drawing.Color.Transparent;
            this.picBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBat.Image = ((System.Drawing.Image)(resources.GetObject("picBat.Image")));
            this.picBat.Location = new System.Drawing.Point(152, 60);
            this.picBat.Name = "picBat";
            this.picBat.Size = new System.Drawing.Size(30, 30);
            this.picBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBat.TabIndex = 13;
            this.picBat.TabStop = false;
            this.picBat.Visible = false;
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Transparent;
            this.picGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picGhost.Image = ((System.Drawing.Image)(resources.GetObject("picGhost.Image")));
            this.picGhost.Location = new System.Drawing.Point(188, 60);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(30, 30);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 14;
            this.picGhost.TabStop = false;
            this.picGhost.Visible = false;
            // 
            // picGhoul
            // 
            this.picGhoul.BackColor = System.Drawing.Color.Transparent;
            this.picGhoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picGhoul.Image = ((System.Drawing.Image)(resources.GetObject("picGhoul.Image")));
            this.picGhoul.Location = new System.Drawing.Point(224, 60);
            this.picGhoul.Name = "picGhoul";
            this.picGhoul.Size = new System.Drawing.Size(30, 30);
            this.picGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhoul.TabIndex = 15;
            this.picGhoul.TabStop = false;
            this.picGhoul.Visible = false;
            // 
            // picBluePotion
            // 
            this.picBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.picBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBluePotion.Image = global::Wyprawa.Properties.Resources.potion_blue;
            this.picBluePotion.Location = new System.Drawing.Point(260, 60);
            this.picBluePotion.Name = "picBluePotion";
            this.picBluePotion.Size = new System.Drawing.Size(30, 30);
            this.picBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBluePotion.TabIndex = 16;
            this.picBluePotion.TabStop = false;
            this.picBluePotion.Visible = false;
            // 
            // picRedPotion
            // 
            this.picRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.picRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRedPotion.Image = global::Wyprawa.Properties.Resources.potion_red;
            this.picRedPotion.Location = new System.Drawing.Point(296, 60);
            this.picRedPotion.Name = "picRedPotion";
            this.picRedPotion.Size = new System.Drawing.Size(30, 30);
            this.picRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPotion.TabIndex = 17;
            this.picRedPotion.TabStop = false;
            this.picRedPotion.Visible = false;
            // 
            // picMace
            // 
            this.picMace.BackColor = System.Drawing.Color.Transparent;
            this.picMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMace.Image = global::Wyprawa.Properties.Resources.mace;
            this.picMace.Location = new System.Drawing.Point(332, 60);
            this.picMace.Name = "picMace";
            this.picMace.Size = new System.Drawing.Size(30, 30);
            this.picMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMace.TabIndex = 18;
            this.picMace.TabStop = false;
            this.picMace.Visible = false;
            // 
            // picBow
            // 
            this.picBow.BackColor = System.Drawing.Color.Transparent;
            this.picBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBow.Image = global::Wyprawa.Properties.Resources.bow;
            this.picBow.Location = new System.Drawing.Point(368, 60);
            this.picBow.Name = "picBow";
            this.picBow.Size = new System.Drawing.Size(30, 30);
            this.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBow.TabIndex = 19;
            this.picBow.TabStop = false;
            this.picBow.Visible = false;
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.BackgroundImage = global::Wyprawa.Properties.Resources.sword;
            this.inventorySword.Location = new System.Drawing.Point(82, 319);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(50, 50);
            this.inventorySword.TabIndex = 20;
            this.inventorySword.TabStop = false;
            this.inventorySword.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.BackgroundImage = global::Wyprawa.Properties.Resources.bow;
            this.inventoryBow.Location = new System.Drawing.Point(138, 319);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(50, 50);
            this.inventoryBow.TabIndex = 21;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.BackgroundImage = global::Wyprawa.Properties.Resources.mace;
            this.inventoryMace.Location = new System.Drawing.Point(194, 319);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(50, 50);
            this.inventoryMace.TabIndex = 22;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.BackgroundImage = global::Wyprawa.Properties.Resources.potion_red;
            this.inventoryRedPotion.Location = new System.Drawing.Point(250, 319);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryRedPotion.TabIndex = 23;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.BackgroundImage = global::Wyprawa.Properties.Resources.potion_blue;
            this.inventoryBluePotion.Location = new System.Drawing.Point(306, 319);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryBluePotion.TabIndex = 24;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // drinkPotion
            // 
            this.drinkPotion.Location = new System.Drawing.Point(673, 209);
            this.drinkPotion.Name = "drinkPotion";
            this.drinkPotion.Size = new System.Drawing.Size(75, 23);
            this.drinkPotion.TabIndex = 25;
            this.drinkPotion.Text = "Wypij";
            this.drinkPotion.UseVisualStyleBackColor = true;
            this.drinkPotion.Visible = false;
            this.drinkPotion.Click += new System.EventHandler(this.attackTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(806, 400);
            this.Controls.Add(this.drinkPotion);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventorySword);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picRedPotion);
            this.Controls.Add(this.picBluePotion);
            this.Controls.Add(this.picGhoul);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picBat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attackDown);
            this.Controls.Add(this.attackRight);
            this.Controls.Add(this.attackLeft);
            this.Controls.Add(this.attackTop);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.moveRight);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.moveTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBow);
            this.Controls.Add(this.picMace);
            this.Controls.Add(this.picSword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveTop;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button attackTop;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picBat;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.PictureBox picGhoul;
        private System.Windows.Forms.PictureBox picBluePotion;
        private System.Windows.Forms.PictureBox picRedPotion;
        private System.Windows.Forms.PictureBox picMace;
        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.Button drinkPotion;
    }
}

