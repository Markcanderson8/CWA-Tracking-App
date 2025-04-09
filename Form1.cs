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
            bool ans = ValidateNumFields(5);
            Console.WriteLine(ans);
        }

        private bool ValidateNumFields(int num)
        {
            string pattern = "\\d";
            Regex regex = new Regex(pattern);
            var x = regex.IsMatch(num.ToString());
            Console.WriteLine(x);
            return x;
        }

        //private bool ValidateDateFields(DateTime date)
        //{

        //}
    }
}
