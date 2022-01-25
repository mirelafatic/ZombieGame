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
    public partial class frmMenu : Form
    {


        public frmMenu()
        {
            InitializeComponent();

            this.btnPlay.Click += BtnPlay_Click;
            this.button2.Click += button2_Click;
            this.button3.Click += button3_Click;
        }


        //btn click events
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            frmGame frmGame = new frmGame(this.txtBoxPlayerName.Text);
            frmGame.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = " Zombes are attacking, dont let them get you! \n Move on WASD keys. \n Shot them with arrows (SPACE) but pay attention on how many of them  you have left. \n Also pay attention on your heath status.\n Get the exrta arrows and health when you see them on the screen! \n GOOD LUCK!  ";

            string title = "Info";

            MessageBox.Show(message, title);
        }


        //
        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {
        }

        private void txtBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
