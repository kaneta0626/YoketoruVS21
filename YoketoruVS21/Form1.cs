using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YoketoruVS21
{
    public partial class Form1 : Form

    {   
        const bool isDebug = true;

        const int SpeedMax = 20;

        const int StartTime = 100;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;


        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];


        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;
    

        const string PlayerText = "(/・ω・)/";
        const string EnemyText = "(;´Д｀)";
        const string ItemText = "💛";

        static Random rand = new Random();

        enum State
        {
            None=-1,        //無効
            Title,          //タイトル
            Game,           //ゲーム
            Gameover,       //ゲームオーバー
            Clear,          //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);

        int ItemCount;
        int time = 0;
        int hiscore = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }

                chrs[i].Font = tempLabel.Font;

                Controls.Add(chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }


            if (nextState!=State.None)
            {
                initProc();
            }

            if(currentState==State.Game)
            {
                UpdateGame();
            }

        }
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameoverLabel.Visible = false;
                    titleButton.Visible = false;
                    clearLabel.Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    copyrightLabel.Visible = false;
                    hiLabel.Visible = false;

                    for (int i  =EnemyIndex; i < ChrMax; i++)
                    {
                  
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }
                    ItemCount = ItemMax;
                    time = StartTime + 1;

                    break;

                case State.Gameover:
                   //MessageBox.Show("GameOver");
                    gameoverLabel.Visible = true;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    //MessageBox.Show("Clear");
                    clearLabel.Visible = true;
                    titleButton.Visible = true;
                    hiLabel.Visible = true;

                    if(time > hiscore)
                    {
                        hiscore = time;
                        hiLabel.Text = "HighScore" + hiscore;
                    }

                    break;

            }
        }

        void UpdateGame()
        {
            time--;
            timeLabel.Text = $"Time{time}";
            
            if(time <= 0)
            {
                nextState = State.Gameover;
            }

            Point mp = PointToClient(MousePosition);

            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;

            for (int i=EnemyIndex;i < ChrMax; i++)
            {
                if (!chrs[i].Visible) continue;

                //TODO: mpがプレイヤーラベルの中心になるように設定
                chrs[i].Left += vx[i];
                chrs[i].Left += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                if ((mp.X >= chrs[i].Left)
                      && (mp.X < chrs[i].Right)
                      && (mp.Y >= chrs[i].Top)
                      && (mp.Y < chrs[i].Bottom)
                    )

                    //当たり判定
                    if ((mp.X >= chrs[i].Left)
                        && (mp.X < chrs[i].Right)
                        && (mp.Y >= chrs[i].Top)
                        && (mp.Y < chrs[i].Bottom)
                        )

                    {
                        //MessageBox.Show("重なった");

                        if (i < ItemIndex)    
                        {
                            nextState = State.Gameover;
                        }
                        else
                        {
                            //アイテム
                            chrs[i].Visible = false;
                            ItemCount--;
                            leftLabel.Text = $"💛:{ItemCount}";
                            if(ItemCount <= 0)
                            {
                                nextState = State.Clear;
                            }

                            //案1
                            //vx[i] = 0;
                            //vy[i] = 0;
                            //chrs[i].Left = 10000;
                        }

                    }

            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
