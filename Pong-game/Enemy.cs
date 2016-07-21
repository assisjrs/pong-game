using System.Drawing;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public class Enemy : Player
    {
        public Enemy(PictureBox player, int height)
            : base(player, height)
        { }

        public void ApplySettings()
        {
            player.BackColor = Properties.Settings.Default.Color_Enemy;
            Speed = Properties.Settings.Default.EnemySpeed;
        }

        public void Move(int ballY)
        {
            if (player.Location.Y + 28 < ballY)
            {
                player.Top += Speed;
            }
            else
            {
                player.Top -= Speed;
            }
        }
    }
}
