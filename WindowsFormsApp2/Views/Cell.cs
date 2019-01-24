using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Views
{
    public class Cell : Button
    {
        #region Constructors

        public Cell(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        #endregion

        #region Properties

        /// <summary>
        /// координата по оси X
        /// </summary>
        public int i { get; private set;}

        /// <summary>
        /// координата по оси Y
        /// </summary>
        public int j { get; private set;}



        #endregion


    }
}
