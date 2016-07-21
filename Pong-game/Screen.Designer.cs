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
            this.pb_PlayerB = new System.Windows.Forms.PictureBox();
            this.pb_PlayerA = new System.Windows.Forms.PictureBox();
            this.timerMoveball = new System.Windows.Forms.Timer(this.components);
            this.labelStart = new System.Windows.Forms.Label();
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.playerB_4 = new System.Windows.Forms.PictureBox();
            this.playerB_5 = new System.Windows.Forms.PictureBox();
            this.playerA_5 = new System.Windows.Forms.PictureBox();
            this.playerA_4 = new System.Windows.Forms.PictureBox();
            this.playerB_1 = new System.Windows.Forms.PictureBox();
            this.playerB_2 = new System.Windows.Forms.PictureBox();
            this.playerB_3 = new System.Windows.Forms.PictureBox();
            this.playerA_3 = new System.Windows.Forms.PictureBox();
            this.playerA_2 = new System.Windows.Forms.PictureBox();
            this.playerA_1 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.Black;
            this.WorldFrame.Controls.Add(this.ball);
            this.WorldFrame.Controls.Add(this.pb_PlayerB);
            this.WorldFrame.Controls.Add(this.pb_PlayerA);
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
            this.pb_PlayerB.BackColor = System.Drawing.Color.Red;
            this.pb_PlayerB.Location = new System.Drawing.Point(409, 67);
            this.pb_PlayerB.Name = "pb_Enemy";
            this.pb_PlayerB.Size = new System.Drawing.Size(15, 70);
            this.pb_PlayerB.TabIndex = 1;
            this.pb_PlayerB.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_PlayerA.BackColor = System.Drawing.Color.SkyBlue;
            this.pb_PlayerA.Location = new System.Drawing.Point(3, 67);
            this.pb_PlayerA.Name = "pb_Player";
            this.pb_PlayerA.Size = new System.Drawing.Size(15, 70);
            this.pb_PlayerA.TabIndex = 0;
            this.pb_PlayerA.TabStop = false;
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
            this.playerB_4.BackColor = System.Drawing.Color.Silver;
            this.playerB_4.Location = new System.Drawing.Point(303, 215);
            this.playerB_4.Name = "enemy_4";
            this.playerB_4.Size = new System.Drawing.Size(15, 15);
            this.playerB_4.TabIndex = 12;
            this.playerB_4.TabStop = false;
            // 
            // enemy_5
            // 
            this.playerB_5.BackColor = System.Drawing.Color.Silver;
            this.playerB_5.Location = new System.Drawing.Point(282, 215);
            this.playerB_5.Name = "enemy_5";
            this.playerB_5.Size = new System.Drawing.Size(15, 15);
            this.playerB_5.TabIndex = 11;
            this.playerB_5.TabStop = false;
            // 
            // player_5
            // 
            this.playerA_5.BackColor = System.Drawing.Color.Silver;
            this.playerA_5.Location = new System.Drawing.Point(132, 215);
            this.playerA_5.Name = "player_5";
            this.playerA_5.Size = new System.Drawing.Size(15, 15);
            this.playerA_5.TabIndex = 10;
            this.playerA_5.TabStop = false;
            // 
            // player_4
            // 
            this.playerA_4.BackColor = System.Drawing.Color.Silver;
            this.playerA_4.Location = new System.Drawing.Point(111, 215);
            this.playerA_4.Name = "player_4";
            this.playerA_4.Size = new System.Drawing.Size(15, 15);
            this.playerA_4.TabIndex = 9;
            this.playerA_4.TabStop = false;
            // 
            // enemy_1
            // 
            this.playerB_1.BackColor = System.Drawing.Color.Silver;
            this.playerB_1.Location = new System.Drawing.Point(366, 215);
            this.playerB_1.Name = "enemy_1";
            this.playerB_1.Size = new System.Drawing.Size(15, 15);
            this.playerB_1.TabIndex = 8;
            this.playerB_1.TabStop = false;
            // 
            // enemy_2
            // 
            this.playerB_2.BackColor = System.Drawing.Color.Silver;
            this.playerB_2.Location = new System.Drawing.Point(345, 215);
            this.playerB_2.Name = "enemy_2";
            this.playerB_2.Size = new System.Drawing.Size(15, 15);
            this.playerB_2.TabIndex = 7;
            this.playerB_2.TabStop = false;
            // 
            // enemy_3
            // 
            this.playerB_3.BackColor = System.Drawing.Color.Silver;
            this.playerB_3.Location = new System.Drawing.Point(324, 215);
            this.playerB_3.Name = "enemy_3";
            this.playerB_3.Size = new System.Drawing.Size(15, 15);
            this.playerB_3.TabIndex = 6;
            this.playerB_3.TabStop = false;
            // 
            // player_3
            // 
            this.playerA_3.BackColor = System.Drawing.Color.Silver;
            this.playerA_3.Location = new System.Drawing.Point(90, 215);
            this.playerA_3.Name = "player_3";
            this.playerA_3.Size = new System.Drawing.Size(15, 15);
            this.playerA_3.TabIndex = 5;
            this.playerA_3.TabStop = false;
            // 
            // player_2
            // 
            this.playerA_2.BackColor = System.Drawing.Color.Silver;
            this.playerA_2.Location = new System.Drawing.Point(69, 215);
            this.playerA_2.Name = "player_2";
            this.playerA_2.Size = new System.Drawing.Size(15, 15);
            this.playerA_2.TabIndex = 4;
            this.playerA_2.TabStop = false;
            // 
            // player_1
            // 
            this.playerA_1.BackColor = System.Drawing.Color.Silver;
            this.playerA_1.Location = new System.Drawing.Point(48, 215);
            this.playerA_1.Name = "player_1";
            this.playerA_1.Size = new System.Drawing.Size(15, 15);
            this.playerA_1.TabIndex = 3;
            this.playerA_1.TabStop = false;
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
            this.Controls.Add(this.playerB_4);
            this.Controls.Add(this.playerB_5);
            this.Controls.Add(this.playerA_5);
            this.Controls.Add(this.playerA_4);
            this.Controls.Add(this.playerB_1);
            this.Controls.Add(this.playerB_2);
            this.Controls.Add(this.playerB_3);
            this.Controls.Add(this.playerA_3);
            this.Controls.Add(this.playerA_2);
            this.Controls.Add(this.playerA_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerA_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox pb_PlayerB;
        private System.Windows.Forms.PictureBox pb_PlayerA;
        private System.Windows.Forms.Timer timerMoveball;
        private System.Windows.Forms.PictureBox playerA_1;
        private System.Windows.Forms.PictureBox playerA_2;
        private System.Windows.Forms.PictureBox playerA_3;
        private System.Windows.Forms.PictureBox playerB_1;
        private System.Windows.Forms.PictureBox playerB_2;
        private System.Windows.Forms.PictureBox playerB_3;
        private System.Windows.Forms.PictureBox playerA_5;
        private System.Windows.Forms.PictureBox playerA_4;
        private System.Windows.Forms.PictureBox playerB_4;
        private System.Windows.Forms.PictureBox playerB_5;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Label labelTime;
    }
}

