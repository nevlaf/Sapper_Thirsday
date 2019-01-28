using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Views;
using WindowsFormsApp2.Controller;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {
        #region Variables
        /// <summary>
        /// Размер ячейки моря
        /// </summary>
        private int size = 20;



        #endregion

        public FormMain()
        {
            InitializeComponent();
            PrepairField();
            Game.Init();



        }
        /// <summary>
        /// Добавление на рабочее поле ячеек
        /// </summary>
        /// 
        private void PrepairField()
        {
            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    Cell cell = new Cell(i, j)
                    {
                        Name = string.Format("{0}_{1}", i, j),
                        //Text = "P",
                        Left = size + i * size,
                        Top = size + j * size,
                        Width = size,
                        Height = size,                        
                    };
                    
                    cell.MouseDown += new MouseEventHandler(cell_MouseDown);
                    Controls.Add(cell);
                }
            }
        }

        private void UpdateField()
        {
            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    switch (Game.mineField[i, j])
                    {
                        case CellState.Empty:
                            break;
                        case CellState.Flag:
                            break;
                        case CellState.Question:
                            


                            //Controls.Find(String.Format("{0}_{1}", i, j), false)[0].Text = "0";
                            // (Controls.Find(String.Format("{0}_{1}", i, j), false)[0] as Cell).TextAlign = ContentAlignment.MiddleCenter;
                            // ((Controls.Find(String.Format("{0}_{1}", i, j), false)[0] as Cell).Parent as Panel).Select();
                            break;                        
                        default:
                            break;
                    }
                }
            }

        }

        #region Event

        /// <summary>
        /// Обработчик нажатия ячеек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_MouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Right)
            {
                switch (Game.mineField[(sender as Cell).i, (sender as Cell).j])
                {
                    case CellState.Empty:
                        Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Flag;
                        (sender as Cell).Text = "P";
                        break;
                    case CellState.Flag:
                        Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Question;
                        (sender as Cell).Text = "?";
                        break;
                    case CellState.Question:
                        Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Empty;
                        (sender as Cell).Text = "";
                        break;
                    default:
                        break;
                }
            }            
        }        

        #endregion
    }
}
