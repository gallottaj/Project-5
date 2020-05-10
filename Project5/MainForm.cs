using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class MainForm : Form
    {
        //declaring global variables

        public static int year;
        public static int month;
        public static int day;
        public static int luckyNumberFormula;
        public static string luckyNumber;

        public MainForm()
        {
            InitializeComponent();

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //calculate lucky number
            year = Convert.ToInt32(yearListBox.SelectedItem);
            day = Convert.ToInt32(dayListBox.SelectedItem);
            month = Convert.ToInt32(monthListBox.SelectedItem);
            luckyNumberFormula = 7 * (year + day + month);
            luckyNumber = luckyNumberFormula.ToString(); 

            //create instance of LuckyNumberForm (form2)
            var myLuckyNumberForm = new LuckyNumberForm();
            myLuckyNumberForm.Show();
        }

    private void monthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void monthNumberCalc()
        {
            
        }

        private void luckyNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
