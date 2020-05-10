using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class LuckyNumberForm : Form
    {

        public LuckyNumberForm()
        {
            InitializeComponent();
        }

        public void LuckyNumberForm_Load(object sender, EventArgs e)
        {
            luckyNumberLabel.Text = MainForm.luckyNumber;

        }

        public void luckyNumberLabel_Click(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luckyNumberTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void luckyNumberLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
