using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//if you want to play, you need press "reset" button every tur/r/n
namespace WindowsFormsApp2
{
    public partial class GameForm : Form
    {
        void Win(int turn)
        {
            
            WinLabel.Text = "Win: " + turn;
        }
        void CheckLogic(int a)
        {
            int turn = 0;
            int scorex = 0;
            int scorey = 0;
            int j = 0;
            var list = gameLog.buttonlist;
            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                turn = 2; 
            }
            else if (gameLog.PlayermoveX == 0 & gameLog.PlayermoveO == 1)
            {
                turn = 1;
            }
                switch (a)
            {
                case 0:
                    Win(turn);
                    for( j = 0; j < gameLog.SideSize; j++)
                    {
                        for(int l = 0; l < gameLog.SideSize; l++)
                        {
                            if (list[j,l]==turn) { ++scorex; }
                            if (list[j,l]!=turn) { scorex = 0; }
                            if (list[l,j]==turn) { ++scorey; }
                            if(list[l,j]!=turn) { scorey = 0; }
                        }
                    }
                    
                    if(scorex==gameLog.SideSize) { Win(turn); }
                    if(scorey!=gameLog.SideSize && scorex!=gameLog.SideSize && gameLog.zero == gameLog.SideSize * gameLog.SideSize) { WinLabel.Text = "Nobody win's!"; }
                    scorex = 0;
                    scorey = 0;
                    break;
                case 1:
                    Win(turn);
                    for (j = 0; j < gameLog.SideSize; j++)
                    {
                        for (int l = 0; l < gameLog.SideSize; l++)
                        {
                            if (list[j, l] == turn) { ++scorex; }
                            if (list[j, l] != turn) { scorex = 0; }
                            if (list[l, j] == turn) { ++scorey; }
                            if (list[l, j] != turn) { scorey = 0; }
                        }
                    }

                    if (scorex == gameLog.SideSize) { Win(turn); }
                    if (scorey != gameLog.SideSize && scorex != gameLog.SideSize && gameLog.zero == gameLog.SideSize * gameLog.SideSize) { WinLabel.Text = "Nobody win's!"; }
                    scorex = 0;
                    scorey = 0;
                    int score = 0;
                    for (j = 0; j < gameLog.SideSize; j++)
                    {
                        for (int l = 0; l < gameLog.SideSize; l++)
                        {
                            if (list[0,0]==turn && list[gameLog.SideSize - 1, gameLog.SideSize - 1] == turn) { score = score + 2; } //
                            if (list[gameLog.SideSize - 1, 0]==turn && list[0, gameLog.SideSize - 1] == turn) { score = score + 2; }
                            if (list[(gameLog.SideSize-1)/2,(gameLog.SideSize - 1)/ 2]==turn) { score = score + 1; }
                            if(score == gameLog.SideSize) { Win(turn); } else if ((list[1,1]==turn & list[gameLog.SideSize - 2, gameLog.SideSize - 2] == turn) || (list[0,gameLog.SideSize-2]==turn && list[1, gameLog.SideSize - 1] == turn)) { score = score + 2; }
                            if (score == gameLog.SideSize) { Win(turn); } else { Win(Convert.ToInt32("12")); }
                            score = 0;
                        }
                    }
                    if (scorex == gameLog.SideSize) { Win(turn); }
                    if (scorey != gameLog.SideSize && scorex != gameLog.SideSize && gameLog.zero == gameLog.SideSize * gameLog.SideSize) { WinLabel.Text = "Nobody win's!"; }
                    scorex = 0;
                    scorey = 0;
                    break;
                default:
                    break;
            }
        }
       void GameCheck()
        {
            var list = gameLog.buttonlist;
            if (list.Length % 2 == 0)
            {
                ArrayLabel.Text = Convert.ToString(list.GetType()) + "\r\n" + "size%2 = 0";

            }
            else if (list.Length % 2 == 1)
            {
                ArrayLabel.Text = Convert.ToString(list.GetType()) + "\r\n" + "size%2 = 1";
            }
            else
            {
                ArrayLabel.Text = Convert.ToString(5%2 + "\r\n" + 7%2 + "\r\n" + 3%2);
            }
            CheckLogic(list.Length%2);
            Task.Delay(1000).GetAwaiter().GetResult();
            ArrayLableUpdate(gameLog.SideSize);
        }
        
         void ArrayLableUpdate(int a)
        {
            
            string outtext = "";
            for (int j = 0;j<a;j++)
            {
                for(int k = 0;k<a;k++)
                {
                    outtext = outtext + Convert.ToString(gameLog.buttonlist[j, k]) + " ";
                    
                }
                outtext = outtext + "\r\n";
                
            }

            if (gameLog.zero == a * a)  outtext = "Finaly";
                ArrayLabel.Text = outtext + "\r\n size:" + Convert.ToString(a*a-gameLog.zero);
        }
        public GameForm()
        {
            InitializeComponent();
            gameLog.PlayermoveX = 1;
        }

        private void butt11_Click(object sender, EventArgs e)
        {
             int i = 0;
            
           
            butt11.Enabled = false;
            
            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0) {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt11.Text = "X";
                i = 1;
               
            } 
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX==0) {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt11.Text = "O"; 
                i = 2;
                
            }
            gameLog.buttonlist[0, 0] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
            
        }

        private void butt12_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt12.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt12.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt12.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[0, 1] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void buttReset_Click(object sender, EventArgs e)
        {
            GameCheck();
        }

        private void butt13_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt13.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt13.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt13.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[0, 2] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);

        }

        private void butt14_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt14.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt14.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt14.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[0, 3] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);

        }

        private void butt21_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt21.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt21.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt21.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[1, 0] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);

        }

        private void butt31_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt31.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt31.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt31.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[2, 0] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);

        }

        private void butt41_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt41.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt41.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt41.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[3, 0] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);

        }

        private void butt22_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt22.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt22.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt22.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[1, 1] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt23_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt23.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt23.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt23.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[1, 2] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt24_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt24.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt24.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt24.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[1, 3] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt32_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt32.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt32.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt32.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[2, 1] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt33_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt33.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt33.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt33.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[2, 2] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt34_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt34.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt34.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt34.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[2, 3] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt42_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt42.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt42.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt42.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[3, 1] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt43_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt43.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt43.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt43.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[3, 2] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }

        private void butt44_Click(object sender, EventArgs e)
        {
            int i = 0;


            butt44.Enabled = false;

            if (gameLog.PlayermoveX == 1 & gameLog.PlayermoveO == 0)
            {
                gameLog.PlayermoveO = 1;
                gameLog.PlayermoveX = 0;
                butt44.Text = "X";
                i = 1;

            }
            else if (gameLog.PlayermoveO == 1 & gameLog.PlayermoveX == 0)
            {
                gameLog.PlayermoveO = 0;
                gameLog.PlayermoveX = 1;
                butt44.Text = "O";
                i = 2;

            }
            gameLog.buttonlist[3, 3] = i;
            gameLog.zero++;
            ArrayLableUpdate(gameLog.SideSize);
        }
    }
}
