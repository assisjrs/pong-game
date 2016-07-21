using System;
using System.Drawing;
using System.Windows.Forms;
using Assisjrs.Ponggame.Properties;

namespace Assisjrs.Ponggame
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void NumericUpDownValueChanged(object sender, EventArgs e)
        {
            var btn = (NumericUpDown)sender;

            if (btn.Value < 1) btn.Value = 1;

            switch (btn.Name)
            {
                case "ballSpeed":
                    Settings.Default.BallSpeed = (int)btn.Value;
                    break;
                case "movimentTimer":
                    Settings.Default.Timer_Movement = (int)btn.Value;
                    break;
                case "playerBSpeed":
                    Settings.Default.EnemySpeed = (int)btn.Value;
                    break;
                case "playerASpeed":
                    Settings.Default.Speed_Player = (int)btn.Value;
                    break;
            }

            Settings.Default.Save();
        }

        private void PlayerAClick(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                playerA.BackColor = dialog.Color;
                Settings.Default.Color_Player = dialog.Color;
            }
            Settings.Default.Save();
        }

        private void PlayerBClick(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                playerB.BackColor = dialog.Color;
                Settings.Default.Color_Enemy = dialog.Color;
            }
            Settings.Default.Save();
        }

        private void BackgroundClick(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                background.BackColor = dialog.Color;
                Settings.Default.Color_Frame = dialog.Color;
            }
            Settings.Default.Save();
        }

        private void SettingsFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Game"].Focus();
        }

        private void ResetAllClick(object sender, EventArgs e)
        {
            background.BackColor = Color.White;
            playerB.BackColor = Color.Red;
            playerA.BackColor = Color.SkyBlue;

            ballSpeed.Value = 3;
            
            movimentTimer.Value = 1;
            playerBSpeed.Value = 1;
            playerASpeed.Value = 1;

            Settings.Default.Timer_Movement = 1;
            Settings.Default.BallSpeed = 3;
            Settings.Default.EnemySpeed = 1;
            Settings.Default.Speed_Player = 1;
            Settings.Default.Color_Frame = Color.White;
            Settings.Default.Color_Enemy = Color.Red;
            Settings.Default.Color_Player = Color.SkyBlue;

            Settings.Default.Save();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            background.BackColor = Settings.Default.Color_Frame;
            playerB.BackColor = Settings.Default.Color_Enemy;
            playerA.BackColor = Settings.Default.Color_Player;

            ballSpeed.Value = Settings.Default.BallSpeed;
            
            movimentTimer.Value = Settings.Default.Timer_Movement;
            playerBSpeed.Value = Settings.Default.EnemySpeed;
            playerASpeed.Value = Settings.Default.Speed_Player;
        }
    }
}
