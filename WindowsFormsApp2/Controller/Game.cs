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

        private static int width = 15;
        private static int height = 12;
        static int countBomb = (width*height);

        public static CellState[,] mineField = new CellState[height, width];


 
        public static void InitField()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
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
                int y = number.Next(width);
                int x = number.Next(height);
                if (mineField[x, y] == CellState.Bomb)
                    {
                    i++;
                    }
                else mineField[x, y] = CellState.Bomb;
                //MessageBox.Show(i); x.ToString(),y.ToString()
            }         
        }
        

        public static int AmountSurraundBomb(int a, int b)
            {
            int sum = 0;
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
            }
    }
 }
    
