using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void clearButton_Click(object sender, EventArgs e)
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            var x = ValidateNumFields(textBoxLoadNumber.Text);
            Console.WriteLine(x);
        }

        private bool ValidateNumFields(string num)
        {
            Regex regex = new Regex("^\\d+$");
            var x = regex.IsMatch(num);
            return x;
        }

        //private bool ValidateDateFields(DateTime date)
        //{

        //}
    }
}
