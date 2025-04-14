using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CWA_Expense_Tracking
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ReadExcelSheet()
        {
            string filePath = "G:\\My Drive\\BUSINESS\\CWA\\P&L Statements\\2025\\Profit & Loss Book.xlsx";
            Excel.Application ex = new Excel.Application();
            Workbook wb;
            Worksheet ws;
            if(File.Exists(filePath))
            {
                wb = ex.Workbooks.Open(filePath);
                ws = wb.Worksheets[2];
                
                MessageBox.Show(Convert.ToString(ws.Cells[40, 6].Value)); // Set up as [row, column]

                wb.Save();
                wb.Close(true);
                ex.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ex);
            }
            else
            {
                MessageBox.Show($"File {filePath} doesn't exist!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadExcelSheet();
        }
    }
}
