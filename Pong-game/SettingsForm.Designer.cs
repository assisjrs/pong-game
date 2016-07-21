namespace Assisjrs.Ponggame
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerA = new System.Windows.Forms.PictureBox();
            this.playerB = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playerASpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.playerBSpeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.resetAll = new System.Windows.Forms.Button();
            this.movimentTimer = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ballSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerASpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerA);
            this.groupBox1.Controls.Add(this.playerB);
            this.groupBox1.Controls.Add(this.background);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cores";
            // 
            // playerA
            // 
            this.playerA.BackColor = System.Drawing.Color.SkyBlue;
            this.playerA.Location = new System.Drawing.Point(106, 19);
            this.playerA.Name = "playerA";
            this.playerA.Size = new System.Drawing.Size(120, 20);
            this.playerA.TabIndex = 7;
            this.playerA.TabStop = false;
            this.playerA.Click += new System.EventHandler(this.PlayerAClick);
            // 
            // playerB
            // 
            this.playerB.BackColor = System.Drawing.Color.Red;
            this.playerB.Location = new System.Drawing.Point(106, 43);
            this.playerB.Name = "playerB";
            this.playerB.Size = new System.Drawing.Size(120, 20);
            this.playerB.TabIndex = 6;
            this.playerB.TabStop = false;
            this.playerB.Click += new System.EventHandler(this.PlayerBClick);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(106, 69);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(120, 20);
            this.background.TabIndex = 4;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.BackgroundClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playerASpeed);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.playerBSpeed);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.resetAll);
            this.groupBox2.Controls.Add(this.movimentTimer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ballSpeed);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações";
            // 
            // playerASpeed
            // 
            this.playerASpeed.Location = new System.Drawing.Point(106, 98);
            this.playerASpeed.Name = "playerASpeed";
            this.playerASpeed.Size = new System.Drawing.Size(120, 20);
            this.playerASpeed.TabIndex = 13;
            this.playerASpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerASpeed.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Player A Speed";
            // 
            // playerBSpeed
            // 
            this.playerBSpeed.Location = new System.Drawing.Point(106, 72);
            this.playerBSpeed.Name = "playerBSpeed";
            this.playerBSpeed.Size = new System.Drawing.Size(120, 20);
            this.playerBSpeed.TabIndex = 11;
            this.playerBSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerBSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Player B Speed";
            // 
            // resetAll
            // 
            this.resetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetAll.Location = new System.Drawing.Point(6, 143);
            this.resetAll.Name = "resetAll";
            this.resetAll.Size = new System.Drawing.Size(220, 23);
            this.resetAll.TabIndex = 9;
            this.resetAll.Text = "Reset all";
            this.resetAll.UseVisualStyleBackColor = true;
            this.resetAll.Click += new System.EventHandler(this.ResetAllClick);
            // 
            // movimentTimer
            // 
            this.movimentTimer.Location = new System.Drawing.Point(106, 45);
            this.movimentTimer.Name = "movimentTimer";
            this.movimentTimer.Size = new System.Drawing.Size(120, 20);
            this.movimentTimer.TabIndex = 8;
            this.movimentTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.movimentTimer.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Movement Timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BallSpeed";
            // 
            // ballSpeed
            // 
            this.ballSpeed.Location = new System.Drawing.Point(106, 19);
            this.ballSpeed.Name = "ballSpeed";
            this.ballSpeed.Size = new System.Drawing.Size(120, 20);
            this.ballSpeed.TabIndex = 0;
            this.ballSpeed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ballSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsFormFormClosed);
            this.Load += new System.EventHandler(this.SettingsFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerASpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ballSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown movimentTimer;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox playerA;
        private System.Windows.Forms.PictureBox playerB;
        private System.Windows.Forms.Button resetAll;
        private System.Windows.Forms.NumericUpDown playerBSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown playerASpeed;
        private System.Windows.Forms.Label label9;
    }
}