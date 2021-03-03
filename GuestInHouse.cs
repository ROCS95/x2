using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonolithConect
{
    public partial class GuestInHouse : Form
    {
        public GuestInHouse()
        {
            InitializeComponent();
        }

        private void GuestInHouse_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"\\192.168.200.95\htdocs\ex_hotel\data.xml");
            dataGridViewGuest.DataSource = dataSet.Tables[0];
        }

        private void copyAlltoClipboard()
        {
            dataGridViewGuest.SelectAll();
            DataObject dataObj = dataGridViewGuest.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);*/
        }
    }
}
