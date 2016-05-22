using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public class Ball
    {
        private PictureBox ball;
        private int width;
        private int height;

        private Random rng = new Random();

        public int Force { get; set; }
        public int Speed { get; set; }
        public bool GoingLeft { get; set; } = true;

        public int Y { get { return ball.Location.Y; } }

        public Ball(PictureBox ball, int width, int height)
        {
            this.ball = ball;
            this.width = width;
            this.height = height;
        }

        public void Start()
        {
            RandomStart(GoingLeft);
        }

        public void Load()
        {
            ball.Location = new Point(208, rng.Next(10, 190));
            RandomStart(GoingLeft);
        }

        public void Over()
        {
            ball.Location = new Point(208, rng.Next(10, 190));
        }

        public delegate void HitPointEventHandler(object source, HitPointEventArgs e);

        public event HitPointEventHandler HitPoint;

        public void OnHitPoint(HitPointEventArgs e)
        {
            if (HitPoint != null)
                HitPoint(this, e);
        }

        public void Tick(Player player, Enemy enemy)
        {
            if (Force > 0)
            {
                ball.Top -= Force;
            }

            if (Force < 0)
            {
                ball.Top -= Force;
            }

            if (ball.Location.Y <= 1)
            {
                Force = ReverseInt(Force, true, true);
            }

            if (ball.Location.Y + ball.Height >= height - 1)
            {
                Force = ReverseInt(Force, true, false);
            }

            if (GoingLeft)
            {
                if (CollisionLeft())
                {
                    var hitPoint = new HitPointEventArgs
                    {
                        IsPlayer = true
                    };

                    OnHitPoint(hitPoint);

                    ball.Location = new Point(206, 67);
                    RandomStart(GoingLeft);
                    Force = 0;
                }

                if (!Collision(player))
                {
                    ball.Left -= Speed;
                }
                else
                {
                    GoingLeft = false;
                }
            }
            else
            {
                if (CollisionRight())
                {
                    var hitPoint = new HitPointEventArgs
                    {
                        IsPlayer = false
                    };

                    OnHitPoint(hitPoint);

                    ball.Location = new Point(206, 67);
                    RandomStart(GoingLeft);
                    Force = 0;
                }

                if (!Collision(enemy))
                {
                    ball.Left += Speed;
                }
                else
                {
                    GoingLeft = true;
                }
            }
        }

        private void RandomStart(bool ballGoingLeft)
        {
            for (var i = 0; i < rng.Next(5, 10); i++)
            {
                ballGoingLeft = !ballGoingLeft;
            }
        }

        private int ReverseInt(int ballForce, bool force = false, bool negative = false)
        {
            if (force)
            {
                if (negative)
                {
                    if (ballForce > 0)
                    {
                        ballForce = ~ballForce + 1;
                    }
                }
                else
                {
                    ballForce = ballForce - (ballForce * 2);
                }
            }
            else
            {
                if (ballForce > 0)
                {
                    ballForce = ballForce - (ballForce * 2);
                }
                else
                {
                    ballForce = ~ballForce + 1;
                }
            }
            return ballForce;
        }

        public void ApplySettings()
        {
            Speed = Properties.Settings.Default.BallSpeed;
        }

        private bool CollisionLeft()
        {
            return ball.Location.X <= 0;
        }

        private bool CollisionRight()
        {
            return ball.Location.X + ball.Width >= width;
        }

        private bool Collision(Enemy enemy)
        {
            var collisionBox = new PictureBox();
            collisionBox.Bounds = enemy.Bounds;

            collisionBox.SetBounds(collisionBox.Location.X - 1, collisionBox.Location.Y, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = 3;
                return true;
            }
            collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 5, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = 2;
                return true;
            }
            collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = 1;
                return true;
            }
            collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = 0;
                return true;
            }
            collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = -1;
                return true;
            }
            collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = -2;
                return true;
            }
            collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);
            if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
            {
                Force = -3;
                return true;
            }

            return false;
        }

        private bool Collision(Player player)
        {
            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                var collisionBox = new PictureBox();

                collisionBox.Bounds = player.Bounds;
                collisionBox.SetBounds(collisionBox.Location.X + collisionBox.Width, collisionBox.Location.Y, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = 3;
                    return true;
                }
                collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 5, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = 2;
                    return true;
                }
                collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = 1;
                    return true;
                }
                collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = 0;
                    return true;
                }
                collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = -1;
                    return true;
                }
                collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = -2;
                    return true;
                }
                collisionBox.SetBounds(collisionBox.Location.X, collisionBox.Location.Y + 10, 1, 10);

                if (ball.Bounds.IntersectsWith(collisionBox.Bounds))
                {
                    Force = -3;
                    return true;
                }
            }

            return false;
        }
    }
}
