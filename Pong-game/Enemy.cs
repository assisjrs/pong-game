using System.Drawing;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public class Enemy
    {
        public Rectangle Bounds
        {
            get { return enemy.Bounds; }
        }

        public int Speed { get; set; }

        private PictureBox enemy;

        public Enemy(PictureBox enemy)
        {
            this.enemy = enemy;
        }

        public void Over()
        {
            enemy.Location = new Point(409, 67);
            ResetScore();
        }

        public void ApplySettings()
        {
            enemy.BackColor = Properties.Settings.Default.Color_Enemy;
            Speed = Properties.Settings.Default.EnemySpeed;
        }

        public int Score { get; set; }

        public void ResetScore()
        {
            Score = 0;
        }

        public void Move(int ballY)
        {
            if (enemy.Location.Y + 28 < ballY)
            {
                enemy.Top += Speed;
            }
            else
            {
                enemy.Top -= Speed;
            }
        }

        public void Load()
        {
            ResetScore();
        }
    }
}
