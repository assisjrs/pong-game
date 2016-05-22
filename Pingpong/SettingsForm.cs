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
                case "enemySpeed":
                    Settings.Default.EnemySpeed = (int)btn.Value;
                    break;
                case "playerSpeed":
                    Settings.Default.Speed_Player = (int)btn.Value;
                    break;
            }

            Settings.Default.Save();
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                player.BackColor = dialog.Color;
                Settings.Default.Color_Player = dialog.Color;
            }
            Settings.Default.Save();
        }

        private void EnemyClick(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                enemy.BackColor = dialog.Color;
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
            enemy.BackColor = Color.Red;
            player.BackColor = Color.SkyBlue;

            ballSpeed.Value = 3;
            
            movimentTimer.Value = 1;
            enemySpeed.Value = 1;
            playerSpeed.Value = 1;

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
            enemy.BackColor = Settings.Default.Color_Enemy;
            player.BackColor = Settings.Default.Color_Player;

            ballSpeed.Value = Settings.Default.BallSpeed;
            
            movimentTimer.Value = Settings.Default.Timer_Movement;
            enemySpeed.Value = Settings.Default.EnemySpeed;
            playerSpeed.Value = Settings.Default.Speed_Player;
        }
    }
}
