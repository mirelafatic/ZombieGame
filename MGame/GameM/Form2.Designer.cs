
namespace GameM
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lblPlayerNameF = new System.Windows.Forms.Label();
            this.lblNameF = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.lblHealth = new System.Windows.Forms.Label();
            this.progressHealth = new System.Windows.Forms.ProgressBar();
            this.panelGame = new System.Windows.Forms.Panel();
            this.picBoxMainPlayer = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKilled = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerNameF
            // 
            this.lblPlayerNameF.AutoSize = true;
            this.lblPlayerNameF.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPlayerNameF.Location = new System.Drawing.Point(111, 10);
            this.lblPlayerNameF.Name = "lblPlayerNameF";
            this.lblPlayerNameF.Size = new System.Drawing.Size(72, 21);
            this.lblPlayerNameF.TabIndex = 0;
            this.lblPlayerNameF.Text = "label1";
            // 
            // lblNameF
            // 
            this.lblNameF.AutoSize = true;
            this.lblNameF.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNameF.Location = new System.Drawing.Point(12, 9);
            this.lblNameF.Name = "lblNameF";
            this.lblNameF.Size = new System.Drawing.Size(102, 22);
            this.lblNameF.TabIndex = 1;
            this.lblNameF.Text = "Player: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(488, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHealth.Location = new System.Drawing.Point(243, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(88, 22);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "Health:";
            // 
            // progressHealth
            // 
            this.progressHealth.ForeColor = System.Drawing.Color.Lime;
            this.progressHealth.Location = new System.Drawing.Point(337, 10);
            this.progressHealth.Name = "progressHealth";
            this.progressHealth.Size = new System.Drawing.Size(173, 23);
            this.progressHealth.TabIndex = 5;
            this.progressHealth.Value = 100;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.BackgroundImage = global::GameM.Properties.Resources.Bcground;
            this.panelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGame.Controls.Add(this.picBoxMainPlayer);
            this.panelGame.Location = new System.Drawing.Point(0, 38);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1009, 529);
            this.panelGame.TabIndex = 3;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // picBoxMainPlayer
            // 
            this.picBoxMainPlayer.BackgroundImage = global::GameM.Properties.Resources.Warrior_11;
            this.picBoxMainPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxMainPlayer.Location = new System.Drawing.Point(192, 316);
            this.picBoxMainPlayer.Name = "picBoxMainPlayer";
            this.picBoxMainPlayer.Size = new System.Drawing.Size(65, 70);
            this.picBoxMainPlayer.TabIndex = 0;
            this.picBoxMainPlayer.TabStop = false;
            this.picBoxMainPlayer.Tag = "mainPlayer";
            this.picBoxMainPlayer.Click += new System.EventHandler(this.picBoxMainPlayer_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblA.Location = new System.Drawing.Point(619, 9);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(107, 21);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "Arrows: ";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblArrow.Location = new System.Drawing.Point(717, 10);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(72, 21);
            this.lblArrow.TabIndex = 7;
            this.lblArrow.Text = "label1";
            this.lblArrow.Click += new System.EventHandler(this.lblArrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(833, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Killed:";
            // 
            // lblKilled
            // 
            this.lblKilled.AutoSize = true;
            this.lblKilled.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilled.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKilled.Location = new System.Drawing.Point(914, 9);
            this.lblKilled.Name = "lblKilled";
            this.lblKilled.Size = new System.Drawing.Size(81, 22);
            this.lblKilled.TabIndex = 9;
            this.lblKilled.Text = "label2";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 563);
            this.Controls.Add(this.lblKilled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblNameF);
            this.Controls.Add(this.progressHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPlayerNameF);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KillM";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNameF;
        private System.Windows.Forms.Label lblNameF;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar progressHealth;
        private System.Windows.Forms.PictureBox picBoxMainPlayer;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKilled;
    }
}