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

namespace WindowsFormsApp2
{
    public partial class GameForm : Form
    {
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
    }
}
