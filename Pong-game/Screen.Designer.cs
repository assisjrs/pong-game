namespace Assisjrs.Ponggame
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pb_Enemy = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.timerMoveball = new System.Windows.Forms.Timer(this.components);
            this.labelStart = new System.Windows.Forms.Label();
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.enemy_4 = new System.Windows.Forms.PictureBox();
            this.enemy_5 = new System.Windows.Forms.PictureBox();
            this.player_5 = new System.Windows.Forms.PictureBox();
            this.player_4 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.player_3 = new System.Windows.Forms.PictureBox();
            this.player_2 = new System.Windows.Forms.PictureBox();
            this.player_1 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.Black;
            this.WorldFrame.Controls.Add(this.ball);
            this.WorldFrame.Controls.Add(this.pb_Enemy);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(427, 209);
            this.WorldFrame.TabIndex = 0;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Image = Properties.Resources.RedBall;
            this.ball.Location = new System.Drawing.Point(198, 83);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(32, 32);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // pb_Enemy
            // 
            this.pb_Enemy.BackColor = System.Drawing.Color.Red;
            this.pb_Enemy.Location = new System.Drawing.Point(409, 67);
            this.pb_Enemy.Name = "pb_Enemy";
            this.pb_Enemy.Size = new System.Drawing.Size(15, 70);
            this.pb_Enemy.TabIndex = 1;
            this.pb_Enemy.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.SkyBlue;
            this.pb_Player.Location = new System.Drawing.Point(3, 67);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(15, 70);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // timerMoveball
            // 
            this.timerMoveball.Enabled = true;
            this.timerMoveball.Interval = 1;
            this.timerMoveball.Tick += new System.EventHandler(this.timerMoveballTick);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(151, 217);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(127, 13);
            this.labelStart.TabIndex = 14;
            this.labelStart.Text = "Press Space to Start";
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timerSecTick);
            // 
            // enemy_4
            // 
            this.enemy_4.BackColor = System.Drawing.Color.Silver;
            this.enemy_4.Location = new System.Drawing.Point(303, 215);
            this.enemy_4.Name = "enemy_4";
            this.enemy_4.Size = new System.Drawing.Size(15, 15);
            this.enemy_4.TabIndex = 12;
            this.enemy_4.TabStop = false;
            // 
            // enemy_5
            // 
            this.enemy_5.BackColor = System.Drawing.Color.Silver;
            this.enemy_5.Location = new System.Drawing.Point(282, 215);
            this.enemy_5.Name = "enemy_5";
            this.enemy_5.Size = new System.Drawing.Size(15, 15);
            this.enemy_5.TabIndex = 11;
            this.enemy_5.TabStop = false;
            // 
            // player_5
            // 
            this.player_5.BackColor = System.Drawing.Color.Silver;
            this.player_5.Location = new System.Drawing.Point(132, 215);
            this.player_5.Name = "player_5";
            this.player_5.Size = new System.Drawing.Size(15, 15);
            this.player_5.TabIndex = 10;
            this.player_5.TabStop = false;
            // 
            // player_4
            // 
            this.player_4.BackColor = System.Drawing.Color.Silver;
            this.player_4.Location = new System.Drawing.Point(111, 215);
            this.player_4.Name = "player_4";
            this.player_4.Size = new System.Drawing.Size(15, 15);
            this.player_4.TabIndex = 9;
            this.player_4.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.Silver;
            this.enemy_1.Location = new System.Drawing.Point(366, 215);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(15, 15);
            this.enemy_1.TabIndex = 8;
            this.enemy_1.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.BackColor = System.Drawing.Color.Silver;
            this.enemy_2.Location = new System.Drawing.Point(345, 215);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(15, 15);
            this.enemy_2.TabIndex = 7;
            this.enemy_2.TabStop = false;
            // 
            // enemy_3
            // 
            this.enemy_3.BackColor = System.Drawing.Color.Silver;
            this.enemy_3.Location = new System.Drawing.Point(324, 215);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(15, 15);
            this.enemy_3.TabIndex = 6;
            this.enemy_3.TabStop = false;
            // 
            // player_3
            // 
            this.player_3.BackColor = System.Drawing.Color.Silver;
            this.player_3.Location = new System.Drawing.Point(90, 215);
            this.player_3.Name = "player_3";
            this.player_3.Size = new System.Drawing.Size(15, 15);
            this.player_3.TabIndex = 5;
            this.player_3.TabStop = false;
            // 
            // player_2
            // 
            this.player_2.BackColor = System.Drawing.Color.Silver;
            this.player_2.Location = new System.Drawing.Point(69, 215);
            this.player_2.Name = "player_2";
            this.player_2.Size = new System.Drawing.Size(15, 15);
            this.player_2.TabIndex = 4;
            this.player_2.TabStop = false;
            // 
            // player_1
            // 
            this.player_1.BackColor = System.Drawing.Color.Silver;
            this.player_1.Location = new System.Drawing.Point(48, 215);
            this.player_1.Name = "player_1";
            this.player_1.Size = new System.Drawing.Size(15, 15);
            this.player_1.TabIndex = 3;
            this.player_1.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(177, 217);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(79, 13);
            this.labelTime.TabIndex = 15;
            this.labelTime.Text = "Time: 00: 00";
            this.labelTime.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 241);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.enemy_4);
            this.Controls.Add(this.enemy_5);
            this.Controls.Add(this.player_5);
            this.Controls.Add(this.player_4);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.player_3);
            this.Controls.Add(this.player_2);
            this.Controls.Add(this.player_1);
            this.Controls.Add(this.WorldFrame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong Game";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormKeyUp);
            this.WorldFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox pb_Enemy;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer timerMoveball;
        private System.Windows.Forms.PictureBox player_1;
        private System.Windows.Forms.PictureBox player_2;
        private System.Windows.Forms.PictureBox player_3;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox player_5;
        private System.Windows.Forms.PictureBox player_4;
        private System.Windows.Forms.PictureBox enemy_4;
        private System.Windows.Forms.PictureBox enemy_5;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Label labelTime;
    }
}

