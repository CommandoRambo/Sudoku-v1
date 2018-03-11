using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Controls
{
    public partial class SudokuCell : UserControl
    {
        // VARIABLES
        private int _number;
        private Label[] _labelName;


        // CONSTRUCTORS
        public SudokuCell()
        {
            InitializeComponent();

            _labelName = new Label[9];

            _labelName[1].Name = lblPencil1.Name;
        }

        // METHODS

        // PROPERTIES
        [Category("Sudoku Cell"), DisplayName("Correct Number")]
        public int CorrectNumber { get; set; }

        [Category("Sudoku Cell"), DisplayName("Pencil Visible")]
        public bool PencilVisible
        {
            get { return lblPencil1.Visible; }
            set { lblPencil1.Visible = value; }
        }

        [Category("Sudoku Cell"), DisplayName("Number Visible")]
        public bool NumberVisible
        {
            get { return lblNumber.Visible; }
            set { lblNumber.Visible = value; }
        }
    }
}
