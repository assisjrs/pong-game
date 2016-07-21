﻿using System.Drawing;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public class Player
    {
        public Rectangle Bounds
        {
            get { return player.Bounds; }
        }

        protected PictureBox player;
        private int height;

        public bool Up { get; set; }
        public bool Down { get; set; } = false;
        public int Speed { get; set; }

        public Point InitialLocation { get; private set; }
        public Color BackColor { get; set; }

        public Player(PictureBox player, int height)
        {
            this.player = player;
            this.height = height;
            InitialLocation = player.Location;
        }

        private bool CollisionUp()
        {
            return player.Location.Y <= 0;
        }

        private bool CollisionDown()
        {
            return player.Location.Y + player.Height >= height;
        }

        public void Tick()
        {
            if (Up && !CollisionUp())
            {
                player.Top -= Speed;
            }

            if (Down && !CollisionDown())
            {
                player.Top += Speed;
            }
        }

        public int Score { get; set; }

        public void ResetScore()
        {
            Score = 0;
        }

        public void Load()
        {
            ResetScore();
            player.Location = InitialLocation;
        }

        public void Move(int ballY)
        {//TODO: Ajustar referencial para player A ou B.
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
