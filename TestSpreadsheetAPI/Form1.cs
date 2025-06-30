using System.IO;

namespace TestSpreadsheetAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var workbook = new DevExpress.Spreadsheet.Workbook();
            var sheet = workbook.Worksheets.FirstOrDefault();
            if (sheet is null)
            {
                workbook.Worksheets.Add();
                sheet = workbook.Worksheets.FirstOrDefault();
            }
            if (sheet != null)
            {
                sheet.Cells["A1"].Value = "Hello, World!";
                sheet.Cells["A2"].Value = "This is a test.";
                sheet.Cells["A3"].Value = DateTime.Now.ToString("G");
                sheet.Cells["A4"].Value = 42;
                workbook.SaveDocument("TestSpreadsheetAPI.xlsx", DevExpress.Spreadsheet.DocumentFormat.Xlsx);
                MessageBox.Show("Workbook saved successfully!");
            }
            else
            {
                MessageBox.Show("No worksheet available.");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //open a workbook from a file
            var workbook = new DevExpress.Spreadsheet.Workbook();
            workbook.LoadDocument("TestSpreadsheetAPI.xlsx", DevExpress.Spreadsheet.DocumentFormat.Xlsx);
            var sheet = workbook.Worksheets.FirstOrDefault();
            MessageBox.Show(sheet?.Cells["A1"].Value.TextValue);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var content = File.ReadAllBytes("TestSpreadsheetAPI.xlsx");
            spreadsheetControl1.LoadDocument(content); 
        }
    }
}
