using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public class GamePlay
    {
        public bool GameOn { get; set; } = false;

        private Player player;
        private Enemy enemy;
        private Ball ball;

        public GamePlay(Panel worldFrame, PictureBox playerPicture, PictureBox enemyPicture, PictureBox ballPicture)
        {
            player = new Player(playerPicture, worldFrame.Height, new Point(3, 67));
            enemy = new Enemy(enemyPicture, 0, new Point(409, 67));
            ball = new Ball(ballPicture, worldFrame.Width, worldFrame.Height);

            ball.HitPoint += BallHitPoint;
        }

        private void BallHitPoint(object source, HitPointEventArgs e)
        {
            if (e.IsPlayer)
                enemy.Score++;
            else
                player.Score++;

            var scoreEvent = new ScoreEventArgs
            {
                IsPlayer = e.IsPlayer,
                Value = e.IsPlayer ? enemy.Score : player.Score
            };

            OnScoreGame(scoreEvent);

            if (scoreEvent.Value == 5)
            {
                Over();
            }
        }

        public event EventHandler ApplyGameSettings;

        public void OnApplyGameSettings(EventArgs e)
        {
            if (ApplyGameSettings != null)
                ApplyGameSettings(this, e);
        }

        public void ApplySettings()
        {
            player.ApplySettings();
            enemy.ApplySettings();
            ball.ApplySettings();

            OnApplyGameSettings(EventArgs.Empty);
        }

        public void UpStart()
        {
            player.Down = false;
            player.Up = true;
        }
        public void UpEnd()
        {
            player.Up = false;
        }

        public void DownStart()
        {
            player.Up = false;
            player.Down = true;
        }
        public void DownEnd()
        {
            player.Down = false;
        }

        public event EventHandler GameStart;

        public void OnGameStart(EventArgs e)
        {
            if (GameStart != null)
                GameStart(this, e);
        }

        public void Start()
        {
            GameOn = true;
            ball.Start();

            OnGameStart(EventArgs.Empty);
        }

        public event EventHandler GameOver;

        public void OnGameOver(EventArgs e)
        {
            if (GameOver != null)
                GameOver(this, e);
        }

        private void Over()
        {
            GameOn = false;

            ball.Over();
            player.Over();
            enemy.Over();

            OnGameOver(EventArgs.Empty);
        }

        public void Load()
        {
            player.Load();
            enemy.Load();

            ApplySettings();
            ball.Load();
        }

        public delegate void ScoreEventHandler(object source, ScoreEventArgs e);

        public event ScoreEventHandler ScoreGame;

        public void OnScoreGame(ScoreEventArgs e)
        {
            if (ScoreGame != null)
                ScoreGame(this, e);
        }

        public void Tick()
        {
            ApplySettings();

            if (GameOn)
            {
                player.Tick();
                ball.Tick(player, enemy);
                enemy.Move(ball.Y);
            }
        }
    }
}
