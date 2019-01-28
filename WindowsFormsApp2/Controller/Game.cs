using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Controller
{
    public static class Game
    {
        #region Variables
        private static int w = 15;
        private static int h = 12;

        public static CellState[,] mineField = new CellState[h, w];

        #endregion
        #region
        public static void Init()
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    mineField[i, j] = CellState.Empty;
                }
            }
        }

        #endregion
    }
}
