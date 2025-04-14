using Microsoft.Office.Interop.Excel;
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
            dateFormatLabel.Visible = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(!(textBoxLoadNumber.Equals("") || textBoxDate.Equals("") || textBoxFrom.Equals("") || textBoxTo.Equals("") || textBoxLoadedMiles.Equals("") || 
                textBoxEmptyMiles.Equals("") || textBoxDriver.Equals("") || textBoxTruck.Equals("") || textBoxPayRate.Equals("") || textBoxLoadRevenue.Equals("") || 
                textBoxTotalPay.Equals(""))) // textBoxSpace.Equals("")
            {
                if (!ValidateDateFields(textBoxDate.Text))
                    dateFormatLabel.Visible = true;
                else
                    dateFormatLabel.Visible = false;
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

        private void ReadExcelSheet()
        {
            string filePath = "G:\\My Drive\\BUSINESS\\CWA\\P&L Statements\\2025\\Profit & Loss Book.xlsx";
            Excel.Application ex = new Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = ex.Workbooks.Open(filePath);
            ws = wb.Worksheets[2];

            MessageBox.Show(Convert.ToString(ws.Cells[40,6].Value)); // Set up as [row, column]

            wb.Save();
            wb.Close(true);
            ex.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ex);
        }
    }
}
