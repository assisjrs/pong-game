using System;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public class GamePlay
    {
        public bool GameOn { get; set; } = false;

        private Player playerA;
        private Player playerB;
        private Ball ball;

        public GamePlay(Panel worldFrame, PictureBox playerAPicture, PictureBox playerBPicture, PictureBox ballPicture)
        {
            playerA = new Player(playerAPicture, worldFrame.Height);
            playerB = new Player(playerBPicture, 0);
            ball = new Ball(ballPicture, worldFrame.Width, worldFrame.Height);

            ball.HitPoint += BallHitPoint;
        }

        private void BallHitPoint(object source, HitPointEventArgs e)
        {
            if (e.IsPlayerA)
                playerB.Score++;
            else
                playerA.Score++;

            var scoreEvent = new ScoreEventArgs
            {
                IsPlayerA = e.IsPlayerA,
                Value = e.IsPlayerA ? playerB.Score : playerA.Score
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
            playerA.BackColor = Properties.Settings.Default.Color_Player;
            playerA.Speed = Properties.Settings.Default.Speed_Player;

            playerB.BackColor = Properties.Settings.Default.Color_Enemy;
            playerB.Speed = Properties.Settings.Default.EnemySpeed;

            ball.Speed = Properties.Settings.Default.BallSpeed;

            OnApplyGameSettings(EventArgs.Empty);
        }

        public void UpStart()
        {
            playerA.Down = false;
            playerA.Up = true;
        }
        public void UpEnd()
        {
            playerA.Up = false;
        }

        public void DownStart()
        {
            playerA.Up = false;
            playerA.Down = true;
        }
        public void DownEnd()
        {
            playerA.Down = false;
        }

        public void Load()
        {
            playerA.Load();
            playerB.Load();

            ApplySettings();
            ball.Load();
        }

        public event EventHandler GameStart;

        public void OnGameStart(EventArgs e)
        {
            if (GameStart != null)
                GameStart(this, e);
        }

        public void Start()
        {
            Load();

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

            OnGameOver(EventArgs.Empty);
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
                playerA.Tick();
                ball.Tick(playerA, playerB);
                playerB.Move(ball.Y);
            }
        }
    }
}
