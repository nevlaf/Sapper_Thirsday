using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;
using System.Windows.Forms;

namespace WindowsFormsApp2.Controller
{
    public static class Game
    {

        private static int width = 12;
        private static int height = 15;
        static int countBomb = 10; // (width*height);

        public static CellState[,] mineField = new CellState[12, 15];


 
        public static void InitField()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    mineField[i, j] = CellState.Empty;
                }
            }
        }




        public static void InitBombs()
        {
            Random number = new Random();
            for(int i = 0; i < countBomb; i++)
            {
                int y = number.Next(15);
                int x = number.Next(12);
                if (mineField[x, y] == CellState.Bomb)
                    {
                    i++;
                    }
                else mineField[x, y] = CellState.Bomb;
                //MessageBox.Show(i); x.ToString(),y.ToString()
            }         
        }
        

        public static int AmountSurraundBomb(int x, int y)
        {
            int sum = 0;
            
            if (x > 0 && y > 0 && mineField[x - 1, y - 1] == CellState.Bomb) sum++;
            if (x > 0 && y > 0 && mineField[x - 1, y] == CellState.Bomb) sum++;
            if (x > 0 && y < 12 && mineField[x - 1, y + 1] == CellState.Bomb) sum++;

            if (y > 0 && mineField[x, y - 1] == CellState.Bomb) sum++;
            if (y < 12 && mineField[x, y + 1] == CellState.Bomb) sum++;

           // if (x < 15 && y > 0 && mineField[x + 1, y - 1] == CellState.Bomb) sum++;
           // if (x < 15 && y > 0 && mineField[x + 1, y ] == CellState.Bomb) sum++;
           // if (x < 15 && y < 12 && mineField[x + 1, y + 1] == CellState.Bomb) sum++;
            return sum;


            /*
             * for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (x - 1 < 0 || y - 1 < 0 || x + 1 > height || y + 1 > width) infield = false;
                    if (mineField[x + i, y + j] == CellState.Bomb && infield)
                    {
                        sum++;
                    }
                }
            }
            */

        }
    }
 }

/*int sum = 0;
            int x = a - 1;
            int y = b - 1;
            for(int i = 0; i < 3; i++)
                {
                for(int j = 0; j < 3; j++)
                    {
                    if(mineField[x + i, y + j] == CellState.Bomb) 
                        {
                        sum++;
                        }
                    }
                }
            return sum;


    int sum = 0;
            
            if(mineField[a - 1, b - 1] == CellState.Bomb) sum++;
            if(mineField[a, b - 1] == CellState.Bomb) sum++;
            if(mineField[a + 1, b - 1] == CellState.Bomb) sum++;
            if(mineField[a - 1, b] == CellState.Bomb) sum++;
            if(mineField[a + 1, b] == CellState.Bomb) sum++;
            if(mineField[a - 1, b + 1] == CellState.Bomb) sum++;
            if(mineField[a, b + 1] == CellState.Bomb) sum++;
            if(mineField[a + 1, b + 1] == CellState.Bomb) sum++;


            return sum;
            */

