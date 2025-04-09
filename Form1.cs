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
using Excel = Microsoft.Office.Interop.Excel;

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
            if(!ValidateDateFields(textBoxDate.Text))
            {
                dateFormatLabel.Visible = true;
            }
        }

        private bool ValidateNumFields(string num)
        {
            Regex regex = new Regex("^\\d+$");
            var x = regex.IsMatch(num);
            return x;
        }

        private bool ValidateDateFields(string date)
        {
            Regex regex = new Regex("\\d{1,2}\\/\\d{1,2}\\/\\d{2,4}");
            var x = regex.IsMatch(date);
            return x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateFormatLabel.Visible = false;
        }
    }
}
