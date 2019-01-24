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



        }

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
                    Controls.Add(cell);
                }
            }
        }

    }
}
