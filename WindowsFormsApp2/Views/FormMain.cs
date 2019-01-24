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
                        Left = size + i * size,
                        Top = size + j * size,
                        Width = size,
                        Height = size,                        
                    };
                    
                    cell.Click += new EventHandler(cell_Click);
                    Controls.Add(cell);
                }
            }
        }
        
        #region Event

        /// <summary>
        /// Обработчик нажатия ячеек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_Click(object sender, System.EventArgs e)
        {
             //string massege = string.Format("i:{0}, j:{1}, i:({2})",
             //    (sender as Cell).i,
             //    (sender as Cell).j,
             //    (sender as Cell).Parent.Name);
             //MessageBox.Show(massege);
            switch (Game.mineField[(sender as Cell).i, (sender as Cell).j])
            {
                case CellState.Empty:
                    Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Flag;
                    break;
                case CellState.Flag:
                    Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Question;
                   // cell((sender as Cell).i, (sender as Cell).j).name = "P";
                    break;
                case CellState.Question:
                    Game.mineField[(sender as Cell).i, (sender as Cell).j] = CellState.Empty;
                    break;
            }
              MessageBox.Show(Game.mineField[(sender as Cell).i, (sender as Cell).j].ToString());

        }        
        #endregion

    }
}
