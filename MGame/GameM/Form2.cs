using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameM
{
    public partial class frmGame : Form
    {

        Graphics g;
        Bitmap img;
        Point playerPosition;

        int speed = 30;
        int amo = 10;
        int zombieSpeed = 7;
        int playerHealth = 100;
        int score = 0;
        bool GameOver = false;
        string facing = "right";
        Random randNum = new Random();
        int ind = 1;
        int ind2 = 0;   //indikator za nove strijele
        int ind3 = 0;  //indikator za health


        List<PictureBox> zombiesList = new List<PictureBox>();


     
        public frmGame(string playerName)
        {
            InitializeComponent();
            this.lblPlayerNameF.Text = playerName;
            this.lblKilled.Text = score.ToString();
            this.picBoxMainPlayer.Tag = "MainPlayer";

            this.lblArrow.Text = this.amo.ToString();

            img = new Bitmap(panelGame.Width, panelGame.Height);
            g = Graphics.FromImage(img);

            this.KeyDown += FrmGame_KeyDown;
            playerPosition = picBoxMainPlayer.Location;


            mainTimer.Tick += MainTimer_Tick;
            mainTimer.Start();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

        }


        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if(playerHealth > 1)
            {
                progressHealth.Value = Convert.ToInt32(playerHealth); 
            }
            else
            { 
                mainTimer.Stop();
                GameOverFun();
            }


            foreach (Control x in this.panelGame.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zombie1" || (string)x.Tag == "zombie2" || (string)x.Tag == "zombie3")
                {
                    if (x.Left > picBoxMainPlayer.Left)
                    {
                        if ((string)x.Tag == "zombie1")
                        {
                            ((PictureBox)x).Image = Properties.Resources.Fullcharacter1;
                        }
                        else if ((string)x.Tag == "zombie3")
                        {
                            ((PictureBox)x).Image = Properties.Resources.Mattack1;
                        }
                        else
                        {
                            ((PictureBox)x).Image = Properties.Resources.Attack2;
                        }
                        x.Left -= zombieSpeed;
                    
                    }
                    if (x.Left < picBoxMainPlayer.Left)
                    {
                        x.Left += zombieSpeed;
                        if ((string)x.Tag == "zombie1")
                        {
                            ((PictureBox)x).Image = Properties.Resources.Fullcharacter2;
                        }
                        else if((string)x.Tag == "zombie3")
                        {
                            ((PictureBox)x).Image = Properties.Resources.Mattack2;
                        }
                        else {
                            ((PictureBox)x).Image = Properties.Resources.Attack1;
                        }
                    }
                    if (x.Top > picBoxMainPlayer.Top)
                    {
                        x.Top -= zombieSpeed;              
                    }
                    if (x.Top < picBoxMainPlayer.Top)
                    {
                        x.Top += zombieSpeed;
                    }
                    if (((PictureBox)x).Bounds.IntersectsWith(picBoxMainPlayer.Bounds))
                    {
                        playerHealth -= 1; 
                        if (playerHealth < 20 && ind3 == 0) {
                            ind3 = 1;
                            this.newHealth();
                        }
                    }
                }

                foreach (Control j in this.panelGame.Controls)
                {
                    if ((j is PictureBox && j.Tag == "arrow") && (x is PictureBox && x.Tag == "zombie1" || x.Tag == "zombie2" || x.Tag == "zombie3"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++; 
                            this.lblKilled.Text = score.ToString();
                            this.Controls.Remove(j); 
                            j.Dispose(); 
                            this.Controls.Remove(x); 
                            x.Dispose();
                            MakeZombies(); 
                        }
                    }
                }
            }


            foreach (Control x in this.Controls) 
            {
                if (x is PictureBox && (string)x.Tag == "nArrows") 
                {
                    if (picBoxMainPlayer.Bounds.IntersectsWith(x.Bounds)) {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        amo += 10;
                        ind2 = 0;
                        this.lblArrow.Text = this.amo.ToString();
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "nHealth")
                {
                    if (picBoxMainPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        playerHealth += 20;
                        ind3 = 0;          
                    }
                }
            }

        }


        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (playerPosition.Y - 310 > 0)
                        playerPosition.Y = playerPosition.Y - 10;
                    break;
                case Keys.Down: 
                    if (playerPosition.Y + 85 < panelGame.Height)
                        playerPosition.Y = playerPosition.Y + 10;
                    break;
                case Keys.Left:
                    if (playerPosition.X - 10 > 0)
                        playerPosition.X = playerPosition.X - 10;
                    picBoxMainPlayer.BackgroundImage = Properties.Resources.Warrior_2;
                    facing = "left";
                    break;
                case Keys.Right:
                    if (playerPosition.X + 50 < panelGame.Width) 
                        playerPosition.X = playerPosition.X + 10;
                    picBoxMainPlayer.BackgroundImage = Properties.Resources.Warrior_11;
                    facing = "right";
                    break;
                case Keys.Space:
                    if(amo > 0)
                    {
                        ShotArrow(facing);
                        this.amo--;
                    }
                    this.lblArrow.Text = this.amo.ToString();
                    if (amo == 0 && ind2 == 0) {
                        this.NewArrows();
                        ind2 = 1;
                    }
                    break;    
            }

            picBoxMainPlayer.Location = playerPosition;
        }


        private void ShotArrow(string direction)
        {
            Arrow shotArrow = new Arrow();
            shotArrow.direction = direction;
            shotArrow.arrowLeft = this.picBoxMainPlayer.Left + (picBoxMainPlayer.Width / 2);
            shotArrow.arrowTop = picBoxMainPlayer.Top + (picBoxMainPlayer.Height / 2);
            shotArrow.MakeArrow(this.panelGame);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            Size size = new Size(35, 35);
            zombie.Size = size;
            if (ind % 2 == 0)
            {
                zombie.Image = Properties.Resources.Attack1;
                zombie.Tag = "zombie2";
            }
            else if (ind % 3 == 0)
            {
                zombie.Image = Properties.Resources.Mattack1;
                zombie.Tag = "zombie3";
            }
            else
            {
                zombie.Image = Properties.Resources.Fullcharacter1;
                zombie.Tag = "zombie1";
            }
            zombie.Left = randNum.Next(200, 900);
            zombie.Top = randNum.Next(300, 500);
            zombie.SizeMode = PictureBoxSizeMode.StretchImage;
            zombiesList.Add(zombie);
            this.panelGame.Controls.Add(zombie);
            picBoxMainPlayer.BringToFront();
            ind++;
        }

        
        private void NewArrows()
        {
            PictureBox nArrow = new PictureBox();
            Color color1 = Color.Transparent;
            nArrow.BackColor = color1;
            nArrow.Image = Properties.Resources.newArrows1;
            Size size1 = new Size(60, 60);
            nArrow.Size = size1; 
            nArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            nArrow.Left = randNum.Next(10, 890); 
            nArrow.Top = randNum.Next(350, 500);
            nArrow.Tag = "nArrows"; 
            this.Controls.Add(nArrow);
            nArrow.BringToFront();
            picBoxMainPlayer.BringToFront();
        }


        private void newHealth() 
        {
            PictureBox nHealth = new PictureBox();
            nHealth.Image = Properties.Resources.health1;
            Size size1 = new Size(60, 60);
            nHealth.Size = size1;
            nHealth.SizeMode = PictureBoxSizeMode.StretchImage;
            nHealth.Left = randNum.Next(10, 890); 
            nHealth.Top = randNum.Next(350, 500); 
            nHealth.Tag = "nHealth";
            this.Controls.Add(nHealth); 
            nHealth.BringToFront(); 
            picBoxMainPlayer.BringToFront(); 
        }
        

        private void RestartGame()
        {
            foreach(PictureBox i in zombiesList)
            {
                this.panelGame.Controls.Remove(i);
            }
            zombiesList.Clear();

            for(int i=0; i<3; i++)
            {
                MakeZombies();
            }

            playerHealth = 100;
            score = 0;
            amo = 10;
            this.lblKilled.Text = score.ToString();
            this.lblArrow.Text = this.amo.ToString();

            mainTimer.Start();
        }


        private void GameOverFun()
        {
            var result = MessageBox.Show(
             "Play Again?",                  
             "The End",                  
             MessageBoxButtons.YesNo, 
             MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes: 
                    RestartGame();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }


        //
        private void lblArrow_Click(object sender, EventArgs e)
        {
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
        }

        private void picBoxMainPlayer_Click(object sender, EventArgs e)
        {
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
