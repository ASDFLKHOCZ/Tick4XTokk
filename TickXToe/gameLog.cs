using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
namespace WindowsFormsApp2
{
    public class gameLog
    {
        public static int SideSize = 4;
        public static int[,] buttonlist = new int[SideSize, SideSize]; //создание масива 4x4
        public static int PlayermoveX = 0; //переменная для проверки хода игрока x
        public static int ScoreX = 0; //переменная для счета побед игрока x
        public static int PlayermoveO = 0; //переменная для проверки хода игрока o
        public static int ScoreO=0; // переменная для счета побед игрока x
        public static int zero = 0; //переменная для проверки количества пустых клеток 
        

    }
}