using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyATM
{
    public partial class WithdrawAmountInput : Form
    {
        public WithdrawAmountInput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int GetWithdrawAmount()
        {
            return (int)numericUpDown1.Value;
        }
    }
}
