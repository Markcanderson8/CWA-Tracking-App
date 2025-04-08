using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWA_Expense_Tracking
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxLoadNumber.Text = "";
            textBoxDate.Text = "";
            textBoxFrom.Text = "";
            textBoxTo.Text = "";
            textBoxLoadedMiles.Text = "";
            textBoxEmptyMiles.Text = "";
            textBoxDriver.Text = "";
            textBoxTruck.Text = "";
            textBoxPayRate.Text = "";
            textBoxLoadRevenue.Text = "";
            textBoxTotalPay.Text = "";
            textBoxSpace.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private bool ValidateStringFields(string str)
        //{

        //}

        //private bool ValidateNumFields(int num)
        //{

        //}

        //private bool ValidateDateFields(DateTime date)
        //{

        //}
    }
}
