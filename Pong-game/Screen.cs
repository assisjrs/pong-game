using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assisjrs.Ponggame
{
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();

            gamePlay = new GamePlay(WorldFrame, pb_PlayerA, pb_PlayerB, ball);

            gamePlay.GameStart += GamePlayGameStart;
            gamePlay.ApplyGameSettings += GamePlayApplyGameSettings;
            gamePlay.GameOver += GamePlayGameOver;
            gamePlay.ScoreGame += GamePlayScoreGame;
        }

        private void GamePlayScoreGame(object source, ScoreEventArgs e)
        {
            var score = scorePlayerA;

            if (e.IsPlayerA)
                score = scorePlayerB;

            for (var i = 0; i < score.Length; i++)
            {
                if (score[i].BackColor == scoreColor)
                {
                    score[i].BackColor = Color.Black;
                    break;
                }
            }
        }

        private void GamePlayGameOver(object sender, EventArgs e)
        {
            labelStart.Visible = true;
            RestoreScore();

            round = 0;
            labelTime.Visible = false;
        }

        private void GamePlayApplyGameSettings(object sender, EventArgs e)
        {
            for (var i = 0; i < 5; i++)
            {
                scorePlayerA[i] = PicID(i + 1);
                scorePlayerB[i] = PicID(i + 1, true);
            }

            WorldFrame.BackColor = Properties.Settings.Default.Color_Frame;
            timerMoveball.Interval = Properties.Settings.Default.Timer_Movement;
        }

        private void GamePlayGameStart(object sender, EventArgs e)
        {
            labelStart.Visible = false;
        }

        private GamePlay gamePlay;

        private PictureBox[] scorePlayerA = new PictureBox[5];
        private PictureBox[] scorePlayerB = new PictureBox[5];
        private Color scoreColor = Color.Silver;

        private int round = 0;

        private void timerMoveballTick(object sender, EventArgs e)
        {
            gamePlay.Tick();
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    gamePlay.UpStart();
                    break;
                case Keys.S:
                case Keys.Down:
                    gamePlay.DownStart();
                    break;
                case Keys.Space:
                    gamePlay.Start();

                    break;
            }
        }

        private void FormKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    gamePlay.UpEnd();
                    break;
                case Keys.S:
                case Keys.Down:
                    gamePlay.DownEnd();
                    break;
            }
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'm')
            {
                gamePlay.GameOn = false;

                var sF = new SettingsForm();
                sF.ShowDialog();

                gamePlay.GameOn = true;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            gamePlay.Load();
        }

        public void RestoreScore()
        {
            for (var i = 0; i <= 5; i++)
            {
                PicID(i).BackColor = scoreColor;
                PicID(i, true).BackColor = scoreColor;
            }
        }

        public PictureBox PicID(int i, bool playerB = false)
        {
            if (playerB)
            {
                switch (i)
                {
                    case 1:
                        return playerB_1;
                    case 2:
                        return playerB_2;
                    case 3:
                        return playerB_3;
                    case 4:
                        return playerB_4;
                    case 5:
                        return playerB_5;
                }
            }
            else
            {
                switch (i)
                {
                    case 1:
                        return playerA_1;
                    case 2:
                        return playerA_2;
                    case 3:
                        return playerA_3;
                    case 4:
                        return playerA_4;
                    case 5:
                        return playerA_5;
                }
            }
            return ball;
        }

        private void timerSecTick(object sender, EventArgs e)
        {
            if (gamePlay.GameOn)
            {
                round++;
                labelTime.Visible = true;

                var time = TimeSpan.FromSeconds(round);

                labelTime.Text = "Time: " + time.ToString(@"mm\:ss");
            }
        }
    }
}
