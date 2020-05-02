using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan3
{
    public partial class Game : Form
    {
        int heroStep = 5;
        int enemyStep = 15;
        int verVelocity = 0;
        int horVelocity = 0;
        int verEnemyVelocity = 0;
        int horEnemyVelocity = 0;
        int verEnemy2Velocity = 0;
        int horEnemy2Velocity = 0;
        int score = 0;
        int heroImage = 1;
        int enemyImage = 1;
        int enemy2Image = 1;
        string heroDirection = "right";
        string enemyDirection = "down";
        string enemy2Direction = "down";
        Random Rand = new Random();
        public Game()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetRandomEnemyDirection()
        {
            int directionCode = Rand.Next(1, 5);
            if (directionCode == 1)
            {
                enemyDirection = "right";
                verEnemyVelocity = 0;
                horEnemyVelocity = enemyStep;
            }
            else if (directionCode == 2)
            {
                enemyDirection = "left";
                verEnemyVelocity = 0;
                horEnemyVelocity = -enemyStep;
            }
            else if (directionCode == 3)
            {
                enemyDirection = "up";
                verEnemyVelocity = -enemyStep;
                horEnemyVelocity = 0;
            }
            else if (directionCode == 4)
            {
                enemyDirection = "down";
                verEnemyVelocity = enemyStep;
                horEnemyVelocity = 0;
            }
        }

        private void SetRandomEnemy2Direction()
        {
            int directionCode2 = Rand.Next(1, 5);
            if (directionCode2 == 1)
            {
                enemy2Direction = "right";
                verEnemy2Velocity = 0;
                horEnemy2Velocity = enemyStep;
            }
            else if (directionCode2 == 2)
            {
                enemy2Direction = "left";
                verEnemy2Velocity = 0;
                horEnemy2Velocity = -enemyStep;
            }
            else if (directionCode2 == 3)
            {
                enemy2Direction = "up";
                verEnemy2Velocity = -enemyStep;
                horEnemy2Velocity = 0;
            }
            else if (directionCode2 == 4)
            {
                enemy2Direction = "down";
                verEnemy2Velocity = enemyStep;
                horEnemy2Velocity = 0;
            }
        }

        private void SetupGame()
        {
            this.BackColor = Color.Blue;
            Hero.BackColor = Color.Transparent;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.BackColor = Color.Transparent;
            Food.Image = Properties.Resources.food_1;
            Food2.BackColor = Color.Transparent;
            Food2.Image = Properties.Resources.food_2;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food2.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.BackColor = Color.Transparent;
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy2.BackColor = Color.Transparent;
            Enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            FreezeBoost.BackColor = Color.Transparent;
            FreezeBoost.SizeMode = PictureBoxSizeMode.StretchImage;
            TimerHeroMove.Start();
            TimerHeroAnimate.Start();
            TimerEnemyAnimate.Start();
            TimerEnemyMove.Start();
            TimerEnemy2Animate.Start();
            TimerEnemy2Move.Start();
            UpdateScoreLabel();
            UpdateSpeedLabel();
        }


        private void Enemy_Click(object sender, EventArgs e)
        {

        }

        private void HeroFoodCollision()
        {
            if (Hero.Bounds.IntersectsWith(Food.Bounds))
            {
                score += 100;
                heroStep += 1;
                enemyStep -= 1;
                RandomizeFood();
                UpdateScoreLabel();
                UpdateSpeedLabel();
            }
        }

        private void HeroFoodCollision2()
        {
            if (Hero.Bounds.IntersectsWith(Food2.Bounds))
            {
                score += 100;
                heroStep += 1;
                enemyStep -= 1;
                RandomizeFood2();
                UpdateScoreLabel();
                UpdateSpeedLabel();
            }
        }

        private void RandomizeFood()
        {
            Food.Left = Rand.Next(0, ClientRectangle.Width - Food.Width);
            Food.Top = Rand.Next(0, ClientRectangle.Height - Food.Height);
            Food.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_" + Rand.Next(1, 5));
        }

        private void RandomizeFood2()
        {
            Food2.Left = Rand.Next(0, ClientRectangle.Width - Food2.Width);
            Food2.Top = Rand.Next(0, ClientRectangle.Height - Food2.Height);
            Food2.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_" + Rand.Next(1, 5));
        }


        private void HeroBorderCollision()
        {
            if (Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
            }
            if (Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
            }
            if (Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
            }
            if (Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
            }
        }

        private void EnemyBorderCollision()
        {
            if (Enemy.Top + Enemy.Height < 0)
            {
                verEnemyVelocity = enemyStep;
                horEnemyVelocity = 0;
                enemyDirection = "down";
            }
            if (Enemy.Top > ClientRectangle.Height)
            {
                verEnemyVelocity = -enemyStep;
                horEnemyVelocity = 0;
                enemyDirection = "up";
            }
            if (Enemy.Left + Enemy.Width < 0)
            {
                verEnemyVelocity = 0;
                horEnemyVelocity = enemyStep;
                enemyDirection = "right";
            }
            if (Enemy.Left > ClientRectangle.Width)
            {
                verEnemyVelocity = 0;
                horEnemyVelocity = -enemyStep;
                enemyDirection = "left";
            }
        }

        private void Enemy2BorderCollision()
        {
            if (Enemy2.Top + Enemy2.Height < 0)
            {
                verEnemy2Velocity = enemyStep;
                horEnemy2Velocity = 0;
                enemy2Direction = "down";
            }
            if (Enemy2.Top > ClientRectangle.Height)
            {
                verEnemy2Velocity = -enemyStep;
                horEnemy2Velocity = 0;
                enemy2Direction = "up";
            }
            if (Enemy2.Left + Enemy2.Width < 0)
            {
                verEnemy2Velocity = 0;
                horEnemy2Velocity = enemyStep;
                enemy2Direction = "right";
            }
            if (Enemy2.Left > ClientRectangle.Width)
            {
                verEnemy2Velocity = 0;
                horEnemy2Velocity = -enemyStep;
                enemy2Direction = "left";
            }
        }

        private void HeroEnemyCollision()
        {
            if (Hero.Bounds.IntersectsWith(Enemy.Bounds))
            {
                GameOver();
            }
        }

        private void HeroEnemy2Collision()
        {
            if (Hero.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            Food.Visible = false;
            Food2.Visible = false;
            Enemy.Visible = false;
            Enemy2.Visible = false;
            TimerHeroMove.Stop();
            TimerHeroAnimate.Stop();
            TimerEnemyAnimate.Stop();
            TimerEnemyMove.Stop();
            heroImage = 0;
            TimerHeroMelt.Start();
        }

        private void Win()
        {
            Food.Visible = false;
            Food2.Visible = false;
            Enemy.Visible = false;
            Enemy2.Visible = false;
            TimerHeroMove.Stop();
            TimerHeroAnimate.Stop();
            TimerEnemyAnimate.Stop();
            TimerEnemyMove.Stop();
            heroImage = 0;
            WinLabel.Visible = true;
            RestartButton.Visible = true;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                verVelocity = -heroStep;
                horVelocity = 0;
                heroDirection = "up";
            }
            else if (e.KeyCode == Keys.S)
            {
                verVelocity = heroStep;
                horVelocity = 0;
                heroDirection = "down";
            }
            else if (e.KeyCode == Keys.A)
            {
                verVelocity = 0;
                horVelocity = -heroStep;
                heroDirection = "left";
            }
            else if (e.KeyCode == Keys.D)
            {
                verVelocity = 0;
                horVelocity = heroStep;
                heroDirection = "right";
            }
            SetRandomEnemyDirection();
            SetRandomEnemy2Direction();
        }

        private void UpdateScoreLabel()
        {
            ScoreLabel.Text = "Score: " + score;
        }

        private void UpdateSpeedLabel()
        {
            EnemySpeedLabel.Text = "Enemy speed: " + enemyStep;
        }

        private void TimerHeroMove_Tick(object sender, EventArgs e)
        {
            Hero.Top += verVelocity;
            Hero.Left += horVelocity;
            HeroBorderCollision();
            HeroFoodCollision();
            HeroFoodCollision2();
            HeroEnemyCollision();
            HeroEnemy2Collision();
            if (enemyStep == 0)
            {
                Win();
            }
        }

        private void TimerHeroAnimate_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImageName = "pacman_" + heroDirection + "_" + heroImage;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            heroImage += 1;
            if (heroImage > 4)
            {
                heroImage = 1;
            }
        }

        private void TimerEnemyAnimate_Tick(object sender, EventArgs e)
        {
            string enemyImageName;
            enemyImageName = "enemy_" + enemyDirection + "_" + enemyImage;
            Enemy.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyImageName);
            enemyImage += 1;
            if (enemyImage > 2)
            {
                enemyImage = 1;
            }
        }

        private void TimerHeroMelt_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImageName = "pacman_melt_" + heroImage;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            heroImage += 1;
            if (heroImage > 14)
            {
                TimerHeroMelt.Stop();
                LabelGameOver.Visible = true;
                RestartButton.Visible = true;
            }
        }

        private void TimerEnemyMove_Tick(object sender, EventArgs e)
        {
            Enemy.Top += verEnemyVelocity;
            Enemy.Left += horEnemyVelocity;
            EnemyBorderCollision();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TimerEnemy2Animate_Tick(object sender, EventArgs e)
        {
            string enemy2ImageName;
            enemy2ImageName = "enemy_" + enemy2Direction + "_" + enemy2Image;
            Enemy2.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy2ImageName);
            enemy2Image += 1;
            if (enemy2Image > 2)
            {
                enemy2Image = 1;
            }
        }

        private void TimerEnemy2Move_Tick(object sender, EventArgs e)
        {
            Enemy2.Top += verEnemy2Velocity;
            Enemy2.Left += horEnemy2Velocity;
            Enemy2BorderCollision();
        }

        private void FreezeBoostAppear_Tick(object sender, EventArgs e)
        {

        }
    }
}
