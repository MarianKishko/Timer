using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class CreateNewTimer : Form
    {
        private Form1 _form1;

        public CreateNewTimer(Form1 form1)
        {
            InitializeComponent();

            this._form1 = form1;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewTimerButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 || numericUpDown2.Value != 0 || numericUpDown3.Value != 0)
            {
                _form1.AddNewTimerFunction(new Timers((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value));
                this.Close();
            }
        }
    }
}
