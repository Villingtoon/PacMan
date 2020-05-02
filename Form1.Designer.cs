namespace PacMan3
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.TimerHeroMove = new System.Windows.Forms.Timer(this.components);
            this.TimerHeroAnimate = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimerEnemyAnimate = new System.Windows.Forms.Timer(this.components);
            this.TimerHeroMelt = new System.Windows.Forms.Timer(this.components);
            this.TimerEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.LabelGameOver = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.Food2 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.TimerEnemy2Animate = new System.Windows.Forms.Timer(this.components);
            this.TimerEnemy2Move = new System.Windows.Forms.Timer(this.components);
            this.WinLabel = new System.Windows.Forms.Label();
            this.EnemySpeedLabel = new System.Windows.Forms.Label();
            this.FreezeBoost = new System.Windows.Forms.PictureBox();
            this.FreezeBoostAppear = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreezeBoost)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Hero.Location = new System.Drawing.Point(13, 13);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(50, 50);
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Yellow;
            this.Food.Location = new System.Drawing.Point(259, 346);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(40, 40);
            this.Food.TabIndex = 1;
            this.Food.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Enemy.Location = new System.Drawing.Point(693, 346);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(40, 40);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            this.Enemy.Click += new System.EventHandler(this.Enemy_Click);
            // 
            // TimerHeroMove
            // 
            this.TimerHeroMove.Interval = 20;
            this.TimerHeroMove.Tick += new System.EventHandler(this.TimerHeroMove_Tick);
            // 
            // TimerHeroAnimate
            // 
            this.TimerHeroAnimate.Tick += new System.EventHandler(this.TimerHeroAnimate_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScoreLabel.Location = new System.Drawing.Point(664, 13);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(56, 28);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score";
            // 
            // TimerEnemyAnimate
            // 
            this.TimerEnemyAnimate.Tick += new System.EventHandler(this.TimerEnemyAnimate_Tick);
            // 
            // TimerHeroMelt
            // 
            this.TimerHeroMelt.Tick += new System.EventHandler(this.TimerHeroMelt_Tick);
            // 
            // TimerEnemyMove
            // 
            this.TimerEnemyMove.Interval = 20;
            this.TimerEnemyMove.Tick += new System.EventHandler(this.TimerEnemyMove_Tick);
            // 
            // LabelGameOver
            // 
            this.LabelGameOver.AutoSize = true;
            this.LabelGameOver.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameOver.ForeColor = System.Drawing.Color.Gold;
            this.LabelGameOver.Location = new System.Drawing.Point(248, 177);
            this.LabelGameOver.Name = "LabelGameOver";
            this.LabelGameOver.Size = new System.Drawing.Size(379, 63);
            this.LabelGameOver.TabIndex = 4;
            this.LabelGameOver.Text = "GAME OVER";
            this.LabelGameOver.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Red;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Rosewood Std Regular", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.Lime;
            this.RestartButton.Location = new System.Drawing.Point(333, 259);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(193, 80);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Food2
            // 
            this.Food2.BackColor = System.Drawing.Color.Yellow;
            this.Food2.Location = new System.Drawing.Point(509, 72);
            this.Food2.Name = "Food2";
            this.Food2.Size = new System.Drawing.Size(40, 40);
            this.Food2.TabIndex = 6;
            this.Food2.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Enemy2.Location = new System.Drawing.Point(748, 398);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(40, 40);
            this.Enemy2.TabIndex = 7;
            this.Enemy2.TabStop = false;
            // 
            // TimerEnemy2Animate
            // 
            this.TimerEnemy2Animate.Tick += new System.EventHandler(this.TimerEnemy2Animate_Tick);
            // 
            // TimerEnemy2Move
            // 
            this.TimerEnemy2Move.Interval = 20;
            this.TimerEnemy2Move.Tick += new System.EventHandler(this.TimerEnemy2Move_Tick);
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLabel.ForeColor = System.Drawing.Color.Lime;
            this.WinLabel.Location = new System.Drawing.Point(272, 177);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(320, 63);
            this.WinLabel.TabIndex = 8;
            this.WinLabel.Text = "YOU WIN!";
            this.WinLabel.Visible = false;
            // 
            // EnemySpeedLabel
            // 
            this.EnemySpeedLabel.AutoSize = true;
            this.EnemySpeedLabel.Font = new System.Drawing.Font("Magneto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemySpeedLabel.ForeColor = System.Drawing.Color.Yellow;
            this.EnemySpeedLabel.Location = new System.Drawing.Point(2, 420);
            this.EnemySpeedLabel.Name = "EnemySpeedLabel";
            this.EnemySpeedLabel.Size = new System.Drawing.Size(178, 32);
            this.EnemySpeedLabel.TabIndex = 9;
            this.EnemySpeedLabel.Text = "Enemy speed: ";
            this.EnemySpeedLabel.UseCompatibleTextRendering = true;
            // 
            // FreezeBoost
            // 
            this.FreezeBoost.Image = ((System.Drawing.Image)(resources.GetObject("FreezeBoost.Image")));
            this.FreezeBoost.Location = new System.Drawing.Point(333, 72);
            this.FreezeBoost.Name = "FreezeBoost";
            this.FreezeBoost.Size = new System.Drawing.Size(30, 30);
            this.FreezeBoost.TabIndex = 10;
            this.FreezeBoost.TabStop = false;
            this.FreezeBoost.Visible = false;
            // 
            // FreezeBoostAppear
            // 
            this.FreezeBoostAppear.Interval = 800;
            this.FreezeBoostAppear.Tick += new System.EventHandler(this.FreezeBoostAppear_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FreezeBoost);
            this.Controls.Add(this.EnemySpeedLabel);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Food2);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.LabelGameOver);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Hero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Loxotron Pac-Man";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreezeBoost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TimerHeroMove;
        private System.Windows.Forms.Timer TimerHeroAnimate;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer TimerEnemyAnimate;
        private System.Windows.Forms.Timer TimerHeroMelt;
        private System.Windows.Forms.Timer TimerEnemyMove;
        private System.Windows.Forms.Label LabelGameOver;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.PictureBox Food2;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.Timer TimerEnemy2Animate;
        private System.Windows.Forms.Timer TimerEnemy2Move;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Label EnemySpeedLabel;
        private System.Windows.Forms.PictureBox FreezeBoost;
        private System.Windows.Forms.Timer FreezeBoostAppear;
    }
}

